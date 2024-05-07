using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public static bool isPaused = false;
    public GameObject HUD;
    public GameObject pauseMenu;
    
    
    public void SceneSwapper(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void Pause()
    {
        if (isPaused == false)
        {
            pauseMenu.SetActive(true);
            isPaused = true;
            Time.timeScale = 0f;
            HUD.SetActive(false);
        }
        else
        {
            pauseMenu.SetActive(false);
            isPaused = false;
            Time.timeScale = 1f;
            HUD.SetActive(true);
        }
    }
    
    
    
}
