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
    static bool isBuyStatus2 = false;
    static bool isBuyStatus3 = false;
    private void Start()
    {
        if (gameObject.layer == 12)
        {
            IsBuy(isBuyStatus2);
        }
        else if (gameObject.layer == 13)
        {
            IsBuy(isBuyStatus3);
        }
    }
    public void OnClickBuy(int price)
    {
        if (Shop.gold >= price)
        {
            if (gameObject.layer == 12)
            {
                isBuyStatus2 = true;
            }
            else if (gameObject.layer == 13)
            {
                isBuyStatus3 = true;
            }
            Shop.gold -= price;
            buyText.text = "Bought";
            buyImage.color = Color.gray;
            buyButton.enabled = false;
            chooseImage.color = Color.white;
            chooseButton.enabled = true;
        }
    }
    void IsBuy(bool status)
    {
        if(status==true)
        {
            buyText.text = "Bought";
            buyImage.color = Color.gray;
            buyButton.enabled = false;
        }
        else 
        {
            buyText.text="Buy";
            buyImage.color=Color.white;
            buyButton.enabled=true;
        }
    }
}
