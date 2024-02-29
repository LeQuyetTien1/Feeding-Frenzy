using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public int lifePoint;
    public int rewardPoint;
    public int gold;
    public Animator animator;
    public float time = 0;
    public virtual void EatAnimation()
    {
        time = 0;
        animator.SetBool("isEat", true);
    }
}
