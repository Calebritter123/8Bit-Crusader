using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame ()
    {
        // SceneManager.LoadScene(1); // Load a Specfic level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load Next Scene
    }
}
