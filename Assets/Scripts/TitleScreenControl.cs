using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenControl : MonoBehaviour
{
    public AudioSource TitleMusic;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Stage 1");
    }

    public void playMusic()
    {
        TitleMusic.Play();
    }

    public void muteMusic()
    {
        TitleMusic.Stop();
    }
}
