using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Shop.previousScene = "Main Menu";
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void GoShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
