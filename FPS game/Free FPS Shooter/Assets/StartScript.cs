using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {

    Animator anim;
    // Use this for initialization
    void Awake () {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Start");
        anim.SetTrigger("Empty");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
