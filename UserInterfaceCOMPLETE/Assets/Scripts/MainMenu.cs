using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;

    private AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void OnPause()
    {
        Pause();
    }

    public void Pause()
    {
        if (isPaused == true)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
            audioManager.PlayAudio(audioManager.background);
        }
        else
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
            audioManager.PauseAudio(audioManager.background);
        }
    }
    
    public void NavButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit the application.");
    }

}
