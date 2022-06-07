using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour
{
    public GameObject pausePanel;
    public void OpenPausePanel(){
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClosePausePanel(){
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Reload(){
        PlayerPrefs.SetInt("LevelCount", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Home(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
    }

    public void NextLevel(){
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }




}
