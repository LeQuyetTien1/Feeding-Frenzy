using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFish : MonoBehaviour
{
    [SerializeField] private float smallFishSpeed = 2;
    private Vector3 direction = Vector3.left;
    [SerializeField] private int lifePoint;
    [SerializeField] private int rewardPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * smallFishSpeed * Time.deltaTime);
        if (transform.position.x > 11 || transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var main = collision.gameObject.GetComponent<Main>();
        if(main!=null && main.score >= lifePoint)
        {
            smallFishSpeed = 3;
            var scale = transform.localScale;
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
            direction *= -1;
        }     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var main = collision.gameObject.GetComponent<Main>();
        if(main!=null && main.score >= lifePoint)
        {
            Destroy(gameObject);
            main.score += rewardPoint;
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
