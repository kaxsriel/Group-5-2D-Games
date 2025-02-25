using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrSceneTransitions : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level One");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level Two");
    }

    public void Help()
    {
        SceneManager.LoadScene("HELP");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
}
