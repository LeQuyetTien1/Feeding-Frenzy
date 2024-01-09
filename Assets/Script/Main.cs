using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public int score;
    public int pointLv2;
    public int pointLv3;
    private Vector3 scaleLv2;
    private Vector3 scaleLv3; 
    // Start is called before the first frame update
    void Start()
    {
        scaleLv2 = transform.localScale * 1.5f;
        scaleLv3 = transform.localScale * 2f;
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
    [ContextMenu("Test")]
    private void UpGrade(int pointLv, Vector3 scaleLv)
    {
        if (score == pointLv)
        {
            transform.localScale = scaleLv;
        }
    }
}
