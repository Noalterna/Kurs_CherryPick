using UnityEngine;
using System.Collections;

public class Heart : MonoBehaviour
{
    Vector3 current_position;
    float direction = 1.0f;
    float speed = 2f;
    float heightlimit = 3.5f;
    float timecount = 0.0f;
    float timelimit = 1f;
    void Start()
    {
    }
    void Update()
    {
        transform.Translate(0, direction * speed * Time.deltaTime * 1, 0);
        if (transform.position.y > current_position.y + heightlimit)
        {
            direction = -1;
        }
        if (transform.position.y < current_position.y)
        {
            direction = 1;
            timecount = timecount + Time.deltaTime;

            if (timecount > timelimit)
            {
                direction = 1;
                timecount = 0;
            }
        }

    }
}
