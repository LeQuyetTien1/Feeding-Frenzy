using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    public Text buyText;
    public Image buyImage;
    public Button buyButton;
    public Image chooseImage;
    public Button chooseButton;
    /*public Shop shop;*/
    public void OnClickBuy(int price)
    {
        if (Shop.gold >= price)
        {
            Shop.gold -= price;
            buyText.text = "Bought";
            buyImage.color = Color.gray;
            buyButton.enabled = false;
            chooseImage.color = Color.white;
            chooseButton.enabled = true;
        }
    }
}
