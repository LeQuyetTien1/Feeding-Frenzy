using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public int lifePoint;
    public int rewardPoint;
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.gameObject.GetComponent<PointSystem>();
        if (enemy != null && enemy.lifePoint >= lifePoint)
        {
            Destroy(gameObject);
            if (enemy.gameObject.layer == 3)
            {
                enemy.lifePoint += rewardPoint;
            }         
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
