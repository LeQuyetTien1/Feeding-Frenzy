using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUI : MonoBehaviour
{
    public PointSystem pointSystem;
    public Text lifePointText;
    public Text goldText;
    private void Start()
    {
        pointSystem= GameObject.FindGameObjectWithTag("Player").GetComponent<Main>();
    }
    void Update()
    {
        lifePointText.text = "Score: "+ pointSystem.lifePoint.ToString();
        goldText.text="x "+pointSystem.gold.ToString();
    }
}
