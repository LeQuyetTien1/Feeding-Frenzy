using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public static string previousScene;
    public void BacktoMenu()
    {
        SceneManager.LoadScene(previousScene);
    }
}
