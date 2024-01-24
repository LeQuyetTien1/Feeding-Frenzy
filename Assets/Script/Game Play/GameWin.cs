using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void NexLevel()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void GoShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
