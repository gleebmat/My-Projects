using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class Buttons : MonoBehaviour
{
    public AudioSource audioSource;


    public AudioClip menuMusic;
    public AudioClip gameMusic;
    public AudioClip GuideButton;
    public AudioClip ReturnButton;

    public AudioClip PauseButton;
    public AudioClip ReturnToGameButton;



    public GameObject image;
    public TextMeshProUGUI record;
    public GameObject guide;
    public GameObject shop;
    public GameObject panel;
    public GameObject exit;
    public GameObject settingsP;
    public GameObject fromSET;
    public GameObject Diff;
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Timer.timeStart = 100;
        PickUpCoins.point = 0;
        Time.timeScale = 1f;
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Pause()
    {
        audioSource.PlayOneShot(PauseButton);
        image.SetActive(true);
        Time.timeScale = 0f;

    }
    public void ExitFromPause()
    {
        audioSource.PlayOneShot(ReturnToGameButton);
        image.SetActive(false);
        Time.timeScale = 1f;
    }
    private void Start()
    {
       
        if(SceneManager.GetActiveScene().name== "SampleScene")
        {
            audioSource.PlayOneShot(gameMusic);
        }
        record.text = Player.scores.Max().ToString();
    }
    public void GuideButtonIn()
    {
        audioSource.PlayOneShot(GuideButton);
        guide.SetActive(true);
        shop.SetActive(false);

    }
    public void GuideButtonFrom()
    {
        audioSource.PlayOneShot(ReturnButton);
        guide.SetActive(false);
        shop.SetActive(true);

    }
    public void ShopIn()
    {
        audioSource.PlayOneShot(GuideButton);
        panel.SetActive(true);
        exit.SetActive(true);
    }
    public void ShopOut()
    {
        panel.SetActive(false);
        exit.SetActive(false);
        audioSource.PlayOneShot(ReturnButton);
    }
    public void SettingsIn()
    {
        audioSource.PlayOneShot(GuideButton);
        settingsP.SetActive(true);
        fromSET.SetActive(true);
        Diff.SetActive(true);
    }

    public void SettingsOut()
    {
        settingsP.SetActive(false);
        fromSET.SetActive(false);
        Diff.SetActive(false);
        audioSource.PlayOneShot(ReturnButton);
    }
}
