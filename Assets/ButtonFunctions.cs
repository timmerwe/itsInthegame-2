using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(13);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
