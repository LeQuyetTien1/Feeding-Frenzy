using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choose : MonoBehaviour
{
    public Button chooseButton;
    public Image chooseImage;
    public Text chooseText;
    public void OnClickChoose()
    {
        chooseText.text = "Chose";
        chooseImage.color = Color.gray;
        chooseButton.enabled = false;
    }
}
