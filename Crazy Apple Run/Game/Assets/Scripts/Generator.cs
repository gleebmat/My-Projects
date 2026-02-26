using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    GameObject knife;
    [SerializeField]
    GameObject coin;
    [SerializeField]
    GameObject apple;
    [SerializeField]
    GameObject potion;
    float timerForKnife = 3;
    float timerForCoins = 7;
    float timerForApples = 5;
    float timerForPotions = 1;



    void Start()
    {
        
    }


    void Update()
    {
        timerForKnife -= Time.deltaTime;
        if(timerForKnife<0)
        {
            if(Timer.timeStart<=100&&Timer.timeStart>75)
            {
                timerForKnife = Random.Range(1.5f, 3f);

            }
            if (Timer.timeStart <= 75 && Timer.timeStart > 50)
            {
                timerForKnife = Random.Range(1.1f, 2.3f);

            }
            if (Timer.timeStart <= 50 && Timer.timeStart > 25)
            {
                timerForKnife = Random.Range(1f, 2f);

            }
            if (Timer.timeStart <= 25 && Timer.timeStart > 0)
            {
                timerForKnife = Random.Range(0.6f, 1f);

            }
            GameObject newKnife = Instantiate(knife, new Vector3(Random.Range(-8f, 8f), 6, 0), Quaternion.identity)as GameObject;
            Destroy(newKnife, 5);
        }


        timerForCoins -= Time.deltaTime;
        if(timerForCoins<0)
        {
            if (Timer.timeStart <= 100 && Timer.timeStart > 75)
            {
                timerForCoins = Random.Range(1.5f, 3f);

            }
            if (Timer.timeStart <= 75 && Timer.timeStart > 50)
            {
                timerForCoins = Random.Range(1.3f, 2.5f);

            }
            if (Timer.timeStart <= 50 && Timer.timeStart > 25)
            {
                timerForCoins = Random.Range(1.2f, 2f);

            }
            if (Timer.timeStart <= 25 && Timer.timeStart > 0)
            {
                timerForCoins = Random.Range(1f, 1.5f);

            }
            GameObject newCoin = Instantiate(coin, new Vector3(Random.Range(-9f, 9f), 6, 0), Quaternion.identity)as GameObject;
            Destroy(newCoin, 5);
        }


        timerForApples -= Time.deltaTime;
        if (timerForApples < 0)
        {
            if (Timer.timeStart <= 100 && Timer.timeStart > 75)
            {
                timerForApples = Random.Range(1.5f, 3f);

            }
            if (Timer.timeStart <= 75 && Timer.timeStart > 50)
            {
                timerForApples = Random.Range(1.3f, 2.5f);

            }
            if (Timer.timeStart <= 50 && Timer.timeStart > 25)
            {
                timerForApples = Random.Range(1.2f, 2f);

            }
            if (Timer.timeStart <= 25 && Timer.timeStart > 0)
            {
                timerForApples = Random.Range(1f, 1.5f);

            }
            GameObject newApple = Instantiate(apple, new Vector3(Random.Range(-9f, 9f), 6, 0), Quaternion.identity) as GameObject;
            Destroy(newApple, 5);
        }
        timerForPotions -= Time.deltaTime;
        if (timerForPotions < 0)
        {
            if (Timer.timeStart < 100 && Timer.timeStart > 0)
            {
                timerForPotions = Random.Range(21f, 24f);
            }
            GameObject newPotion = Instantiate(potion, new Vector3(Random.Range(-9f, 9f), 6, 0), Quaternion.identity) as GameObject;
            Destroy(newPotion, 5);
        }
    }
}
