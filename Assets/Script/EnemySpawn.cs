using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private float timeSpawn;
    [SerializeField] private float maxHeight;
    [SerializeField] private float minHeight;
    [SerializeField] GameObject enemyFish;
    [SerializeField] private float angle;
    private float time=0;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
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
}