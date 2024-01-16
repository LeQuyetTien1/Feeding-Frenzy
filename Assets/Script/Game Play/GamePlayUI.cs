using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUI : MonoBehaviour
{
    public PointSystem pointSystem;
    public Text lifePointText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifePointText.text = pointSystem.lifePoint.ToString();
    }
}
