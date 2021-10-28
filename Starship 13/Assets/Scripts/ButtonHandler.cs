﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Titel");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
