using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{

    public void GoHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // from Mission 01 to Home Screen
    }

    public void GoHome02()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); // From Mission 02 to Home Screen
    }
}
