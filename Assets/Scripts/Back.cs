using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{

    public void GoHome01()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // from Mission 01 to Home Screen
    }

    public void GoHome02()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); // From Mission 02 to Home Screen
    }

    public void GoHome03()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3); // From Mission 02 to Home Screen
    }

    public void GoHome04()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4); // From Mission 02 to Home Screen
    }

    public void GoHome05()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5); // From Mission 02 to Home Screen
    }

    public void GoHome06()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6); // From Mission 02 to Home Screen
    }

    public void GoHome07()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7); // From Mission 02 to Home Screen
    }
}
