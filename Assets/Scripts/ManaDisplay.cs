using UnityEngine;

public class ManaDisplay : MonoBehaviour
{
    [SerializeField]
    private Color activeColor;
    [SerializeField]
    private Color inactiveColor;
    [SerializeField]
    private GameObject cellPrefab;

    public void SetProgress(int currentMana, int maxMana)
    {
        while (transform.childCount < maxMana)
        {
            Instantiate(cellPrefab, transform);
        }
        while (transform.childCount > maxMana)
        {
            transform.GetChild(0).SetParent(null);
            Destroy(transform.GetChild(0).gameObject);
        }

        for (int i = 0; i < transform.childCount; i++)
        {
            var cell = transform.GetChild(i);
            var image = cell.GetComponent<UnityEngine.UI.Image>();
            if (image != null)
            {
                if (i < currentMana)
                {
                    image.color = activeColor;
                }
                else
                {
                    image.color = inactiveColor;
                }
            }
        }
    }
}
