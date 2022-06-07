using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Count : MonoBehaviour
{
    private int enemyCount;
    void Start()
    {
        enemyCount = PlayerPrefs.GetInt("LevelCount");
        enemyCount +=1;
        gameObject.GetComponent<Text>().text = "Enemies:  " + enemyCount;

    }
}
