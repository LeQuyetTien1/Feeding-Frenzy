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
    // Start is called before the first frame update
    void Start()
    {
        onGameOver.AddListener(enemySpawnLeft.StopSpawn);
        onGameOver.AddListener(enemySpawnRight.StopSpawn);
        onGameOver.AddListener(ShowGameOver);

        onGameWin.AddListener(enemySpawnLeft.StopSpawn);
        onGameWin.AddListener(enemySpawnRight.StopSpawn);
        onGameWin.AddListener(ShowGameWin);
        Shop.previousScene = "Level 1";
    }

    // Update is called once per frame
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
}
