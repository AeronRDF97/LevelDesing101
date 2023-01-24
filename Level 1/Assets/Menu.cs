using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject creditsMenu;
    [SerializeField] GameObject mainMenu;

    public void StartGame()
    {

        SceneManager.LoadScene("SampleScene");

    }

   

    public void Credits()
    {

        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
      

    }

    public void Quit()
    {
        Application.Quit();

        Debug.Log("Quit");
    }

    public void Back()
    {

        mainMenu.SetActive(true);
        creditsMenu.SetActive(false);
    }
}


