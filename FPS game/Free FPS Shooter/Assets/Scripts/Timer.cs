using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public PlayerHealth playerHealth;
    public Text timer;
    public float mainTimeLeft = 30.0f;
    private bool canCount = true;
    public float timeLeft;

    private void Start()
    {
        timeLeft = mainTimeLeft;
    }
    // Update is called once per frame
    void Update () {
       
        if (timeLeft> 0.0f &&canCount)
        {
            timeLeft -= Time.deltaTime;
            timer.text = "TIME LEFT " + timeLeft.ToString("F");
        }
        if (timeLeft<=0)
        {
            canCount = false;
            playerHealth.Death();
        }
	}
  
}