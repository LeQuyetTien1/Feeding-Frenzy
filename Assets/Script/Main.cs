using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.mousePosition.x < 1920 && Input.mousePosition.y < 1080 & Input.mousePosition.x > 0 && Input.mousePosition.y > 0)
        {
            var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPoint.z = 0;
            transform.position = worldPoint;
        }      
    }
}
