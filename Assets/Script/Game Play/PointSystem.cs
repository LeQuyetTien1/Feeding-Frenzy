using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public int lifePoint;
    public int rewardPoint;
    public int gold;
    public Animator animator;
    protected float time=0;
    private void Update()
    {
        
    }
    protected void OnCollisionEnter2D(Collision2D collision) //Body
    {
        /*if(collision.gameObject.layer==9)*/
        var enemy = collision.gameObject.GetComponent<PointSystem>();
        if (enemy != null && enemy.lifePoint >= lifePoint)
        {
            Destroy(gameObject);
            if (enemy.gameObject.layer == 3)
            {
                enemy.lifePoint += rewardPoint;
                enemy.gold += gold;
                
            }
        }
        else
        {
            Destroy(collision.gameObject);
            time = 0;
            animator.SetBool("isEat", true);           
        }
    }
}
