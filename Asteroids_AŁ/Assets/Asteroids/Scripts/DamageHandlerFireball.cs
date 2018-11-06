using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerFireball : MonoBehaviour
{

    int health = 1;

    //if player hits the enemy he dies
    private void OnTriggerEnter2D()
    {
        health--;
    }
    private void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
