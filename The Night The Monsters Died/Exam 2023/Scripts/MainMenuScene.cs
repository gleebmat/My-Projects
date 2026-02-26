using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScene : MonoBehaviour
{
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void StartButton(int index)
    {
        SceneManager.LoadScene(index);
 

    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Update()
    {
        StartButton();
    }

    private void StartButton()
    {
        throw new NotImplementedException();
    }
}
