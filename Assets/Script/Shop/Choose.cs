using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choose : MonoBehaviour
{
    public Button chooseButton;
    public Image chooseImage;
    public Text chooseText;

    public Button otherMainButton1;
    public Image otherMainImage1;
    public Text otherMainText1;

    public Button otherMainButton2;
    public Image otherMainImage2;
    public Text otherMainText2;

    public Button buyButton;
    private void Start()
    {
        if (gameObject.layer == 12)
        {
            IsChoose(GameLogic.status2);
        }
        if (gameObject.layer == 13)
        {
            IsChoose(GameLogic.status3);
        }
        if (gameObject.layer == 11)
        {
            IsChoose(GameLogic.status1);
        }
       
        Debug.Log("Buy button status " + gameObject.layer + " " + buyButton.name+" "+buyButton.enabled);
        Debug.Log("isBuyStatus2: " + Buy.isBuyStatus2);
        Debug.Log("isBuyStatus3: " + Buy.isBuyStatus3);
    }
    public void OnClickChoose()
    {
        chooseText.text = "Selected";
        chooseImage.color = Color.gray;
        chooseButton.enabled = false;       
        ChangeButton(otherMainButton1, otherMainImage1, otherMainText1);
        ChangeButton(otherMainButton2, otherMainImage2, otherMainText2);


        ChangeStatus(11, true, false, false);
        ChangeStatus(12, false, true, false);
        ChangeStatus(13, false, false, true);
    }
    public void ChangeButton(Button chooseButton, Image chooseImage, Text chooseText)
    {
        if (chooseText.text == "Selected")
        {
            chooseButton.enabled = true;
            chooseImage.color = Color.white;
            chooseText.text = "Select";
        }        
    }
    public void ChangeStatus(int layer, bool status1, bool status2, bool status3)
    {
        if (gameObject.layer == layer)
        {
            GameLogic.status1 = status1;
            GameLogic.status2 = status2;
            GameLogic.status3 = status3;
        }
    }
    void IsChoose(bool status)
    {
        if(status==true)
        {
            chooseText.text = "Selected";
            chooseImage.color = Color.gray;
            chooseButton.enabled = false;
        }
        else
        {
            chooseText.text="Select";
            if (buyButton!=null&&buyButton.enabled == true)
            {
                chooseImage.color = Color.gray;
                chooseButton.enabled = false;
            }
            else if(buyButton!=null&&buyButton==false)
            {
                chooseImage.color = Color.white;
                chooseButton.enabled = true;
            }
        }
    }
}
