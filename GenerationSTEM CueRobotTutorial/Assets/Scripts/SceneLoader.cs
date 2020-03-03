using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void PlayTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void StartScreen()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void Transition()
    {
        SceneManager.LoadScene("Transition");
    }

}
