using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CapsuleCollider))]
public class Obstacle : MonoBehaviour
{
    private int durability = 5;
    private CapsuleCollider obstacleCollider;

    private void Start()
    {
        obstacleCollider = GetComponent<CapsuleCollider>();    
    }


    public void durabilityLowered()
    {
        if(durability <= 0)
        {
            StartCoroutine(RechargeDurability());
        }
    }

    IEnumerator RechargeDurability()
    {
        obstacleCollider.enabled = false;
        yield return new WaitForSeconds(2f);
        obstacleCollider.enabled = true;
        durability = 5;
    }
}
