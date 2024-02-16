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
            fish.EatAnimation();
            var enemy = collision.gameObject.GetComponent<PointSystem>();
            if (enemy != null && enemy.lifePoint <= fish.lifePoint)
            {
                Destroy(collision.gameObject);
                if (fish.gameObject.layer == 3)
                {
                    fish.lifePoint += enemy.rewardPoint;
                    fish.gold += enemy.gold;
                }
            }
        }
    }
}
