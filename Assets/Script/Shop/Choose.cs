using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choose : MonoBehaviour
{
    public Button chooseButton;
    public Image chooseImage;
    public Text chooseText;

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
    }
}
