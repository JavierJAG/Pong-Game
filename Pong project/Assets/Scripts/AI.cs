using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed = 3;
    
    public GameObject ball;

    private Vector2 ballPosition;

    void Move()
    {
        ballPosition = ball.transform.position;

        if (transform.position.y > ballPosition.y)
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime);
        }
        if (transform.position.y < ballPosition.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }
    }

    void Update()
    {
        Move();
    }
}
