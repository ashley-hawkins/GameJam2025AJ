using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster Instance;

    List<string> logLines = new List<string>();
    [SerializeField]
    private TMPro.TextMeshProUGUI outputText;
    [SerializeField]
    private CardHandDisplay playerHandDisplay;
    [SerializeField]
    private InfusionButtonGroup infusionButtonGroup;
    [SerializeField]
    private ManaDisplay manaDisplay;
    [SerializeField]
    private HealthBarDisplay healthBarDisplay;
    Player playerData;
    public EnemyTracker enemyTracker;

    public bool IsPlayerTurn = true;

    int playerTargetSelection = -1;

    private void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        print("test");
        playerData = new Player(playerHandDisplay);
        BeginPlayerTurn();
    }

    public void BeginPlayerTurn()
    {
        IsPlayerTurn = true;
        playerData.mana = playerData.maxMana;
        playerData.ReplenishHand(7);
        playerHandDisplay.DisplayHand(playerData.hand);
        OutputText("Player's turn begins. Mana replenished.");
        RefreshDisplays();
    }

    public void OutputText(string text)
    {
        foreach (var line in text.Split('\n'))
        {
            logLines.Add(line);
        }
        while (logLines.Count > 4)
        {
            logLines.RemoveAt(0);
        }
        outputText.text = string.Join("\n", logLines);
    }

    public void OnGoButtonPressed()
    {
        if (!IsPlayerTurn)
        {
            OutputText("It's not your turn!");
            return;
        }

        if (playerData.mana <= 0)
        {
            OutputText("Not enough mana to play a card.");
            return;
        }

        int selectedIndex = playerHandDisplay.SelectedIndex();
        if (selectedIndex == -1)
        {
            OutputText("No card selected.");
            return;
        }
        int selectedInfusionIndex = infusionButtonGroup.SelectedIndex();
        if (selectedInfusionIndex == -1)
        {
            OutputText("No infusion selected.");
            return;
        }

        Card.Infusion infusion;
        if (selectedInfusionIndex == 0)
        {
            infusion = Card.Infusion.Fire;
        }
        else if (selectedInfusionIndex == 1)
        {
            infusion = Card.Infusion.Ice;
        }
        else if (selectedInfusionIndex == 2)
        {
            infusion = Card.Infusion.Lightning;
        }
        else
        {
            OutputText("Invalid infusion selected.");
            return;
        }

        Card card = playerData.hand[selectedIndex];
        card.infusion = infusion;

        CardInfusion.Effect effect = CardInfusion.InfusionResult(card);

        print(effect.Describe());

        if (playerTargetSelection == -1)
        {
            OutputText("No target selected.");
            return;
        }

        CardTarget target;
        if (playerTargetSelection == 0)
        {
            target = PlayerTarget();
        }
        else
        {
            target = EnemyTarget(playerTargetSelection - 1);
        }

        target.ApplyEffect(effect);
        playerData.RemoveCardFromHand(selectedIndex);
        --playerData.mana;
        RefreshDisplays();
        infusionButtonGroup.ClearSelection();

        OutputText($"Played card at index {selectedIndex}.");
    }

    public void OnEndTurnButtonPressed()
    {
        if (!IsPlayerTurn)
        {
            OutputText("It's not your turn!");
            return;
        }

        IsPlayerTurn = false;
        StartCoroutine(enemyTracker.TakeEnemiesTurns());
    }

    public CardTarget PlayerTarget()
    {
        return playerData.playerTarget;
    }

    public CardTarget EnemyTarget(int enemyIndex)
    {
        return enemyTracker.GetEnemyAtIndex(enemyIndex).enemyTarget;
    }

    public void RefreshDisplays()
    {
        manaDisplay.SetProgress(playerData.mana, playerData.maxMana);
        healthBarDisplay.SetProgress(playerData.playerTarget.health, playerData.playerTarget.maxHealth);
    }

    public void SelectSelf()
    {
        playerTargetSelection = 0;
    }

    public void SelectEnemy(int enemyIndex)
    {
        playerTargetSelection = enemyIndex + 1;
    }
}
