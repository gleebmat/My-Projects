using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public void lose()
    {
        SceneManager.LoadScene("Menu");
    }
    public void win()
    {
        SceneManager.LoadScene("Menu");
    }



}
