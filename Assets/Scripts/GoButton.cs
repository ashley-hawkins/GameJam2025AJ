using System;
using UnityEngine;

public class GoButton : MonoBehaviour
{
    public void GoButtonPressed()
    {
        GameMaster.Instance.OnGoButtonPressed();
    }
    public void EndButtonPressed()
    {
        GameMaster.Instance.OnEndTurnButtonPressed();
    }
}
