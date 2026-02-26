using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class Timer : MonoBehaviour
{
    public static float timeStart = 100;
    public TextMeshProUGUI timerText;
    public GameObject winPanel;
    public TextMeshProUGUI points;
    public Button pauseButton;

    void Start()
    {
        timerText.text = timeStart.ToString();

    }

    void Update()
    {
        timeStart -= Time.deltaTime;

        timerText.text = Mathf.Round(timeStart).ToString();
        if(timeStart<=0)
        {
            points.text = PickUpCoins.point.ToString();
            Player.scores.Add(PickUpCoins.point);
            PlayerPrefs.SetInt("Coins", CoinText.Coin);
            pauseButton.interactable = false;
            winPanel.SetActive(true);           
            Time.timeScale = 0f;

        }

    }
}
