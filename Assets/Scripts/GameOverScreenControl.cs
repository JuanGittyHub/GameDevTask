using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreenControl : MonoBehaviour
{

    public void ExitGame()
    {
        Application.Quit();
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("Stage 1");
    }

    public void ReturnToTitle()
    {
        SceneManager.LoadScene("Title Screen");
    }

}
