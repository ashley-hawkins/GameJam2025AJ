using TMPro;
using UnityEngine;

public class HealthBarDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI healthText;
    [SerializeField]
    private Transform healthBar;

    void Start()
    {
        // Test
        SetProgress(85, 100);
    }


    void SetProgress(int current, int max)
    {
        healthText.text = current + " / " + max;
        float ratio = (float)current / max;
        healthBar.localScale = new Vector3(ratio, 1, 1);
    }
}
