using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHome : MonoBehaviour
{
    public GameManager gameManager;
    public UIManager uiManager;

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Play()
    {
        uiManager.ChangeMenu(UIManager.MENU.GAMEPLAY);
        gameManager.StartGame();
    }

    public void Exit()
    {

    }
}
