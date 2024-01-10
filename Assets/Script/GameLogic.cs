using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameLogic : MonoBehaviour
{
    public EnemySpawn enemySpawnLeft;
    public EnemySpawn enemySpawnRight;
    /*public EnemyFish enemyFish;*/
    public GameObject gameOver;
    public Main mainFish;
    public UnityEvent onGameOver;
    // Start is called before the first frame update
    void Start()
    {
        onGameOver.AddListener(enemySpawnLeft.StopSpawn);
        onGameOver.AddListener(enemySpawnRight.StopSpawn);
        onGameOver.AddListener(ShowGameOver);
    }

    // Update is called once per frame
    void Update()
    {
        if (mainFish == null)
        {
            onGameOver.Invoke();
        }
    }
    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }
}
