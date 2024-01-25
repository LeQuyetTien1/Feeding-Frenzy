using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFish : PointSystem
{
    public float speed;
    protected Vector3 direction = Vector3.left;
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (transform.position.x > 11 || transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var main = collision.gameObject.GetComponent<Main>();
        if (main != null && main.lifePoint >= lifePoint)
        {
            speed = 3;
            var scale = transform.localScale;
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
            direction *= -1;
        }
    }
}
