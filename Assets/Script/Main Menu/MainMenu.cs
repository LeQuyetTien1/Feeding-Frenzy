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
        SceneManager.LoadScene("Game Play");
    }
    public void GoShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
