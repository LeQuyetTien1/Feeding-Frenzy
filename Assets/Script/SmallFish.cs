using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallFish : MonoBehaviour
{
    [SerializeField] private float smallFishSpeed = 2;
    private Vector3 direction = Vector3.left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( direction * smallFishSpeed * Time.deltaTime);
        if (transform.position.x > 11 || transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {      
        smallFishSpeed = 3;
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {       
        Destroy(gameObject);
    }
}
