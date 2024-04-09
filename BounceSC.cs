using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSC : MonoBehaviour
{
    public Rigidbody2D ballRB;

    public GameObject ball;


    
   

    void Start()
    {
        ballRB.velocity = new Vector3(0,0,0);

    }

    void Update()
    {
        NoStuck();
    }

    private void NoStuck()
    {
        if(ballRB.velocity.x == 0)
        {
            ballRB.velocity = new Vector2(Random.Range(1, 3), ballRB.velocity.y);
        }

    }

    
}

