using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public static bool isGamePaused = false;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject creditsMenu;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        creditsMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        creditsMenu.SetActive(false);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void Credits()
    {

        pauseMenu.SetActive(false);
        creditsMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;

    }

    public void Quit()
    {
        Application.Quit();

        Debug.Log("Quit");
    }
}
