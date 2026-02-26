using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenu1;
    [SerializeField] KeyCode KeyMenuPause;
    bool isMenuPaused;
    private void Start()
    {
        PauseMenu1.SetActive(false);
    }
    void ActiveMenu()
    {
        if(Input.GetKeyDown(KeyMenuPause))
        {
            isMenuPaused = !isMenuPaused;
        }

        if(isMenuPaused)
        {
            PauseMenu1.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else
        {
            PauseMenu1.SetActive(false);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    private void Update()
    {
        ActiveMenu();
    }
    public void Continue()
    {
        Time.timeScale = 1f;
        isMenuPaused = false;
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
