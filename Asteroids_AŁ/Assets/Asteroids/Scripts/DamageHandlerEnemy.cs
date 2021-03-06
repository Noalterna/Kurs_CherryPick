﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerEnemy : MonoBehaviour {

    int health = 1;
    Vector2 position;
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
        Debug.Log("dead");
        GameController.instance.PlayerScored();
        transform.position = new Vector2(-15, 25);
        Revive();
    }
    void Revive()
    {
        health = 1;

    }
}
