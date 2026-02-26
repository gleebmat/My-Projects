using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Heartsystem : MonoBehaviour
{
    public static int health;
    public GameObject Heart1, Heart2, Heart3;
    public GameObject fHeart1, fHeart2, fHeart3;
    public TextMeshProUGUI points;
    public GameObject losePanel;
    public Button pauseButton;
    void Start()
    {
        Heart1.SetActive(true);
        Heart2.SetActive(true);
        Heart3.SetActive(true);
        fHeart1.SetActive(false);
        fHeart2.SetActive(false);
        fHeart3.SetActive(false);
        health = 3;
        
    }

  
    void Update()
    {
        if(health == 3)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);

            fHeart1.SetActive(false);
            fHeart2.SetActive(false);
            fHeart3.SetActive(false);
        }
        else if(health == 2)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(false);

            fHeart1.SetActive(false);
            fHeart2.SetActive(false);
            fHeart3.SetActive(true);
        }
        else if(health == 1)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(false);
            Heart3.SetActive(false);

            fHeart1.SetActive(false);
            fHeart2.SetActive(true);
            fHeart3.SetActive(true);
        }
        else if (health == 0)
        {
            Heart1.SetActive(false);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
            fHeart1.SetActive(true);
            fHeart2.SetActive(true);
            fHeart3.SetActive(true);
            pauseButton.interactable = false;

            points.text = PickUpCoins.point.ToString();
            losePanel.SetActive(true);
            Time.timeScale = 0f;

        }
    }
}
