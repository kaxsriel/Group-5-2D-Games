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

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Subway Door"))
        {
            SceneManager.LoadScene("Level One");
        }

        if (other.CompareTag("Subway Door 2"))
        {
            SceneManager.LoadScene("Level Two");
        }

        if (other.CompareTag("Chip"))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
