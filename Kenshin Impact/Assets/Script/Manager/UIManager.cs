using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public UIHome home;
    public UIGameplay gameplay;
    public UIPause pause;
    public UISetting setting;

    public void ChangeMenu(MENU menu)
    {
        
    }

    public enum MENU
    {
        NONE = 0,
        HOME = 1,
        GAMEPLAY = 2,
        PAUSE = 3,
        SETTING = 4
    }
}
