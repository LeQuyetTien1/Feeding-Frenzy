using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFish : PointSystem
{
    public float speed;
    public Vector3 direction = Vector3.left;
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (transform.position.x > 11 || transform.position.x < -12)
        {
            Destroy(gameObject);
        }

        time += Time.deltaTime;
        if (time >= 0.5)
        {
            animator.SetBool("isEat", false);
        }
    }
}
