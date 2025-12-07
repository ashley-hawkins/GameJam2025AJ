using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    void OnMouseDown()
    {
        GameMaster.Instance.SelectSelf();
    }
}
