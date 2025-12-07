using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class UICard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        // transform.localPosition.y
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

}
