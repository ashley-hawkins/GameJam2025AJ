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
        RefreshDisplays();
        RefreshOutputText();
    }

    public void BeginPlayerTurn()
    {
        IsPlayerTurn = true;
        playerData.mana = playerData.maxMana;
        playerData.ReplenishHand(7);
        playerHandDisplay.DisplayHand(playerData.hand);
        RefreshDisplays();
    }

    public void RefreshOutputText()
    {

        outputText.text = string.Join("\n", logLines);
    }

    public void OutputText(string text)
    {
        foreach (var line in text.Split('\n'))
        {
            logLines.Add(line);
        }
        while (logLines.Count > 6)
        {
            logLines.RemoveAt(0);
        }
        RefreshOutputText();
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
            OutputText("Not enough mana to play a card.\nYou should end your turn now.");
            return;
        }

        int selectedIndex = playerHandDisplay.SelectedIndex();
        if (selectedIndex == -1)
        {
            OutputText("No card selected.\nPlease select a card to play.");
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
            OutputText("No target selected. Click a target.");
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

        GameMaster.Instance.OutputText(effect.DescribeAsSentenceSingle("Player", playerTargetSelection == 0 ? "Player" : "Enemy " + (playerTargetSelection)));
        if (playerTargetSelection == 0 && effect.IsNegativeEffect() || playerTargetSelection != 0 && effect.IsPositiveEffect())
        {
            GameMaster.Instance.OutputText("A self-sabotage!");
        }

        playerData.RemoveCardFromHand(selectedIndex);
        --playerData.mana;
        RefreshDisplays();
        infusionButtonGroup.ClearSelection();
    }

    public void OnEndTurnButtonPressed()
    {
        if (!IsPlayerTurn)
        {
            OutputText("It's not your turn!");
            return;
        }
        playerData.playerTarget.EndTurn();
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
