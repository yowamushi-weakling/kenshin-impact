using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;

    public GameObject player;
    public GameObject startPoint;

    // Start is called before the first frame update
    private void Start()
    {
        Init();
    }

    public void Init()
    {
        uiManager.ChangeMenu(UIManager.MENU.HOME);
    }

    public void StartGame()
    {
        player.transform.position = startPoint.transform.position;
    }

    public void Win()
    {
        Debug.Log("Win");
    }

    public void Lose()
    {
        Debug.Log("Lose");
    }
}
