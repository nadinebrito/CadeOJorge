using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    private GameController controll;
    private int levelCount;

    void Start(){
        levelCount = PlayerPrefs.GetInt("LevelCount");
        controll = GameObject.Find("GameController").GetComponent<GameController>();
    }
    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Player"){
            if(PlayerPrefs.GetInt("LevelCount")<5){
                PlayerPrefs.SetInt("LevelCount", levelCount+1);
            }
            controll.PlayerWin();
        }
    }
}
