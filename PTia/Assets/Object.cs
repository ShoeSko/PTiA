using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Object : MonoBehaviour
{
    private int health;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            TakeDamage();
            collision.gameObject.GetComponent<Obstacle>().durabilityLowered();
        }
    }

    public virtual void TakeDamage()
    {
        if(health <= 0)
        {
            Destruction();
        }
    }

    public void Destruction()
    {
        Destroy(gameObject);
    }
}
