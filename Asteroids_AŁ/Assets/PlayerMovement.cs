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
        verticalMove += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.position = new Vector2(horizontalMove, verticalMove);
      
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg -90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);



    }
}
