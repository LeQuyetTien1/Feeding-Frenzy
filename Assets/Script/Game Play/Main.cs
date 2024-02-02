using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Main : PointSystem
{
    public int pointLv2;
    public int pointLv3;
    public Vector3 scaleLv2;
    public Vector3 scaleLv3;
    public int winPoint;
    public Image greenBar;
    public bool isWinStatus=false;
    private Vector3 currentMouse;
    // Start is called before the first frame update
    void Start()
    {
        currentMouse = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentMouse.x < Input.mousePosition.x)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            currentMouse = Input.mousePosition;
        }
        if(currentMouse.x>Input.mousePosition.x)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
            currentMouse= Input.mousePosition;
        }
        if (Input.mousePosition.x < 1920 && Input.mousePosition.y < 1080 && Input.mousePosition.x > 0 && Input.mousePosition.y > 0 && isWinStatus==false)
        {
            var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPoint.z = 0;
            transform.position = worldPoint;
        }
        UpGrade(pointLv2, scaleLv2);
        UpGrade(pointLv3, scaleLv3);
        greenBar.fillAmount = (float) lifePoint / winPoint;

        time += Time.deltaTime;
        if (time >= 0.5)
        {
            animator.SetBool("isEat", false);
        }

        Shop.gold = gold;
    }
    private void UpGrade(int pointLv, Vector3 scaleLv)
    {
        if (lifePoint >= pointLv)
        {
            transform.localScale = scaleLv;
        }
    }
}
