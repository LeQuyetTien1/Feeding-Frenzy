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

    private void Start()
    {
        chooseImage.color = Color.gray;
        chooseButton.enabled = false;
    }
    public void OnClickChoose()
    {
        chooseText.text = "Selected";
        chooseImage.color = Color.gray;
        chooseButton.enabled = false;
        ChangeButton(otherMainButton1, otherMainImage1, otherMainText1);
        ChangeButton(otherMainButton2, otherMainImage2, otherMainText2);
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
}
