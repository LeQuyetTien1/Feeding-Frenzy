using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
