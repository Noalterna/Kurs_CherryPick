using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerPlayer : MonoBehaviour {

    int health = 1;
    bool isDead = false; 

    //if player hits the enemy he dies
    private void OnTriggerEnter2D()
    {
        health--;
        if (health<=0)
        {
            Die();
        }
    }
    void Die()
    {
        isDead = true;
        GameController.instance.PlayerDied();
    }
}
