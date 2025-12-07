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
    Player playerData;

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
}
