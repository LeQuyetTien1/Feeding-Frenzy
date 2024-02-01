using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    public EnemyFish fish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) //Radar
    {
        var main = collision.gameObject.GetComponent<Main>();
        if (main != null && main.lifePoint >= fish.lifePoint)
        {
            fish.speed = 3;
            var scale = fish.transform.localScale;
            fish.transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
            fish.direction *= -1;
        }
    }
}
