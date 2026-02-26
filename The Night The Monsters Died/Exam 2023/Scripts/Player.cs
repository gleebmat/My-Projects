using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    public Text TextTakeAmmo;

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("AmmoBox"))
        {
            TextTakeAmmo.gameObject.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                PlayerManager.bulletAmount += 10;
                TextTakeAmmo.gameObject.SetActive(false);
                Destroy(other.gameObject);
            }
        }
        if(other.CompareTag("MedKit"))
        {
            TextTakeAmmo.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(PlayerManager.playerHP>80)
                {
                    PlayerManager.playerHP = 100;
                }
                else
                {
                    PlayerManager.playerHP += 20;

                }
                TextTakeAmmo.gameObject.SetActive(false);
                Destroy(other.gameObject);
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        TextTakeAmmo.gameObject.SetActive(false);
    }
    private void Start()
    {
        
    }
}
