using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private float timeSpawn;
    private float maxHeight= 4.22f;
    private float minHeight= -4.7f;
    [SerializeField] GameObject enemyFish;
    [SerializeField] private float angle;
    private float time=0;
    void Update()
    {
        if(time < timeSpawn)
        {
            time += Time.deltaTime;
        }
        else
        {
            Spawn();
            time = 0;
        }
    }
    private void Spawn()
    {
        Instantiate(enemyFish, new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), 0), Quaternion.Euler(0,angle,0));
    }
    public void StopSpawn()
    {
        gameObject.SetActive(false);
    }
}
