using System;
using UnityEngine;

public class GoButton : MonoBehaviour
{
    public void GoButtonPressed()
    {
        GameMaster.Instance.OnGoButtonPressed();
    }
}
