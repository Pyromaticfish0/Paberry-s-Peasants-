// Adam Bell

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads mission 01 (AugmentedImages) in index queue

    }

    public void PlayGame02()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); // Loads mission 02 (HelloAR scene) in index queue
    }

    public void QuitGame()
    {
        Debug.Log("Quit Successful! Go Parberrys' Peasants!");
        Application.Quit();
    }
}
