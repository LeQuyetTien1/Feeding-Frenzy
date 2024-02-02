using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static string previousScene;
    public static int gold;
    public Text goldText;
   
    private void Start()
    {
        goldText.text = "x " + gold.ToString();
    }
    private void Update()
    {
        goldText.text = "x " + gold.ToString();
    }
    public void Back()
    {
        SceneManager.LoadScene(previousScene);
    }
}
