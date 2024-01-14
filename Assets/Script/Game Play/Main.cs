using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Main : PointSystem
{
    /*public int mainPoint;*/
    public int pointLv2;
    public int pointLv3;
    public Vector3 scaleLv2;
    public Vector3 scaleLv3;
    
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
        UpGrade(pointLv2, scaleLv2);
        UpGrade(pointLv3, scaleLv3);
    }
    private void UpGrade(int pointLv, Vector3 scaleLv)
    {
        if (lifePoint >= pointLv)
        {
            transform.localScale = scaleLv;
        }
    }
}
