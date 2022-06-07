using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public GameObject[] enemies;
    private int levelCount;

    public void Start(){
        levelCount = PlayerPrefs.GetInt("LevelCount");
        for(int i=0;i<levelCount+1;i++){
            enemies[i].SetActive(true);
        }

    }
}
