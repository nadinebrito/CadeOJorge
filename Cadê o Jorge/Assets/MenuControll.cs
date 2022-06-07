using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControll : MonoBehaviour
{
    public void PlayGame()
    {
        PlayerPrefs.SetInt("LevelCount", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
   
}
