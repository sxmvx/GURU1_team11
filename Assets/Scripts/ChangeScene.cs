using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void ChangeSceneLoad()
    {
        SceneManager.LoadScene("SaveLoad");
    }

    public void ChangeSceneExit()
    {
        Application.Quit();
    }

    public void ChangeSceneMain()
    {
        SceneManager.LoadScene("Main");
    }
}