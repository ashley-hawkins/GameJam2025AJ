using TMPro;
using UnityEngine;

public class HealthBarDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI healthText;
    [SerializeField]
    private Transform healthBar;

    public void SetProgress(int current, int max)
    {
        healthText.text = current + " / " + max;
        float ratio = (float)current / max;
        healthBar.localScale = new Vector3(ratio, 1, 1);
    }
}
