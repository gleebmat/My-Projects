using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;

public class Canvas : MonoBehaviour
{
    public TextMeshProUGUI text;
    [SerializeField]  Dropdown dropdown;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text =""+PickUpCoins.point;
    }
}
