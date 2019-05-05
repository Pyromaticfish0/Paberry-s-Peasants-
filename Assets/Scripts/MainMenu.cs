// Adam Bell

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame01()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads Mission1 in index queue
    }

    public void PlayGame02()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); // Loads Mission2 in index queue
    }

    public void PlayGame03()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3); // Loads Mission3 in index queue
    }

    public void PlayGame04()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4); // Loads Mission4 in index queue
    }

    public void PlayGame05()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5); // Loads Mission5 in index queue
    }

    public void PlayGame06()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6); // Loads Mission6 in index queue
    }

    public void PlayGame07()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7); // Loads Mission7 in index queue
    }

    public void QuitGame()
    {
        Debug.Log("Quit Successful! Go Parberrys' Peasants!");
        Application.Quit();
    }
}
