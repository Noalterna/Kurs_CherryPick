using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Vector2 position;
    public int speed = 6;
    float horizontalMove;
    float verticalMove;
	// Use this for initialization
	void Start () {
	    	
	}
	
	// Update is called once per frame
	void Update () {
        horizontalMove += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        //transform.position = new Vector2(horizontalMove,0);

        verticalMove += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.position = new Vector2(horizontalMove, verticalMove);

	}
}
