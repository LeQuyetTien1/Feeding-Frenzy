using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour
{
    public PointSystem fish;
    
    protected void OnTriggerEnter2D(Collider2D collision) //Body
    {
        if (collision.gameObject.layer != 10)
        {
            
            var enemy = collision.gameObject.GetComponent<PointSystem>();
            if (fish.gameObject.layer==3 && enemy.lifePoint <= fish.lifePoint)
            {
                fish.EatAnimation();
                Destroy(collision.gameObject);
                fish.lifePoint += enemy.rewardPoint;
                fish.gold += enemy.gold;
            }
            else if (fish.gameObject.layer != 3 && enemy.lifePoint < fish.lifePoint)
            {
                fish.EatAnimation();
                Destroy(collision.gameObject);
            }
        }
    }
}
