using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransirion : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
