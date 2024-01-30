using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static string previousScene;
    public int gold;
    public Text goldText;
    /*public Text buyText;
    public Image buyImage;
    public Button buyButton;*/
    private void Start()
    {
        goldText.text = "x " + gold.ToString();
    }
    private void Update()
    {
        goldText.text = "x " + gold.ToString();
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene(previousScene);
    }
    /*public void OnClickBuy(int price)
    {
        if (gold >= price)
        {
            gold -= price;
            buyText.text = "Bought";
            buyImage.color = Color.gray;
            buyButton.enabled = false;
        }
    }*/
}
