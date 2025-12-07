using UnityEngine;

public class InfusionButtonGroup : MonoBehaviour
{
    public int SelectedIndex()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var iconButton = transform.GetChild(i).GetComponent<IconButton>();
            if (iconButton != null && iconButton.isSelected)
            {
                return i;
            }
        }
        return -1;
    }

    public void ClearSelection()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var iconButton = transform.GetChild(i).GetComponent<IconButton>();
            if (iconButton != null && iconButton.isSelected)
            {
                iconButton.ToggleSelection();
            }
        }
    }
}
