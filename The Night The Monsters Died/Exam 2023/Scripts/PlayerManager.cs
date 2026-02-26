using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    public GameObject lose;
    public GameObject win;
    public Slider healthBar;
    public static int playerHP;
    public static bool gameOver;
    public TextMeshProUGUI playerHPText;
    public TextMeshProUGUI bulletAmountText;
    public GameObject redOverlay;
    public Text Day;
    public static int days = 1;

    public static int bulletAmount=10;

    void Start()
    {
        healthBar.value = playerHP;
        playerHP = 100;
        gameOver = false;


    }

    void Update()
    {
        playerHPText.text = "" + playerHP;
        bulletAmountText.text = "" + bulletAmount;
        healthBar.value = playerHP;
        Day.text = "" + days;
        if(days==8)
        {
            Time.timeScale = 0f;
            win.SetActive(true);
        }
        if (gameOver)
        {
            Time.timeScale = 0f;
            lose.SetActive(true);
        }


    }

    public IEnumerator Damage(int damageCount)
    {
        playerHP -= damageCount;
        redOverlay.SetActive(true);
        if (playerHP <= 0)
        {
            gameOver = true;
        }
        yield return new WaitForSeconds(2f);
        redOverlay.SetActive(false);
    }

}
