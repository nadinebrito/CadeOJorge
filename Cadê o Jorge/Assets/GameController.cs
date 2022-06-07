using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject defeatPanel;
    public GameObject victoryPanel;
    public void PlayerDie(){
        defeatPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void PlayerWin(){
        victoryPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
