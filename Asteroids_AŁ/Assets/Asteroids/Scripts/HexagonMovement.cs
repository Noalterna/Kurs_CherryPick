using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonMovement : MonoBehaviour {

    public float speed = 2f;
    Vector2 pos;
	// Use this for initialization
	void Start () {
        Rigidbody2D r2d = GetComponent<Rigidbody2D>();
        r2d.angularVelocity = Random.Range(-20, 20);
    }
	// Update is called once per frame
	void Update () {
        pos = transform.position;

        if (pos.x >= 20 || pos.y >=20 || pos.x <=-20 || pos.x <=-20)
        {
            speed *= -1;
        }
        transform.Translate(speed*Time.deltaTime , speed * Time.deltaTime ,0);
	}
}
