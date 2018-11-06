using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject fireballPrefab;
    float timeDelay = 0.25f;
    float coolDownTimer = 0f;
	// Update is called once per frame
	void Update () {
        coolDownTimer -= Time.deltaTime;
        if (Input.GetButton("Fire1") && coolDownTimer <=0)
        {
            Vector3 shift = transform.rotation * new Vector3(0, 1f, 0);
            Instantiate(fireballPrefab,transform.position +shift, transform.rotation);
            coolDownTimer = timeDelay;
        }
	}
}
