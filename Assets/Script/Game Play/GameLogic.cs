using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameLogic : MonoBehaviour
{
    public EnemySpawn enemySpawnLeft;
    public EnemySpawn enemySpawnRight;
    public GameObject gameOver;
    public GameObject gameWin;
    public Main mainFish;
    public UnityEvent onGameOver;
    public UnityEvent onGameWin;
    public Main main1, main2, main3;
    public static bool status1=true, status2=false, status3=false;
    void Start()
    {
        /*TestMainActive(main1, status1);
        TestMainActive(main2, status2);
        TestMainActive(main3, status3);*/
        mainFish = GameObject.FindGameObjectWithTag("Player").GetComponent<Main>();

        onGameOver.AddListener(enemySpawnLeft.StopSpawn);
        onGameOver.AddListener(enemySpawnRight.StopSpawn);
        onGameOver.AddListener(ShowGameOver);

        onGameWin.AddListener(enemySpawnLeft.StopSpawn);
        onGameWin.AddListener(enemySpawnRight.StopSpawn);
        onGameWin.AddListener(ShowGameWin);
        Shop.previousScene = "Level 1";
    }

    void Update()
    {       
        if (mainFish == null)
        {
            onGameOver.Invoke();
        }
        if (mainFish.lifePoint >= mainFish.winPoint)
        {
            mainFish.greenBar.fillAmount = 1;
            onGameWin.Invoke();
        }       
    }
    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }
    public void ShowGameWin()
    {
        gameWin.SetActive(true);
        mainFish.isWinStatus = true;
    }
    public void TestMainActive(Main main, bool status)
    {
        if (main != null)
        {
            if (status == true)
            {
                main.gameObject.SetActive(true);
            }
            else
            {
                main.gameObject.SetActive(false);
            }
        }
        
    }
}
