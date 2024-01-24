using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUI : MonoBehaviour
{
    public PointSystem pointSystem;
    public Text lifePointText;
    public Text goldText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifePointText.text = "Score: "+ pointSystem.lifePoint.ToString();
        goldText.text="x "+pointSystem.gold.ToString();
    }
}
