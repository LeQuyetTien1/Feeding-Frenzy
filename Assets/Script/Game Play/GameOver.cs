using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    public void PlayNewGame()
    {
        SceneManager.LoadScene("Game Play");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
