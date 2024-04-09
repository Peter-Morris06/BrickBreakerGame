using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreBalls : MonoBehaviour
{
    public GameObject ball;
    
    public int turns;

    private GameObject currentball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turns = ball.GetComponent<DrawLine>().numTurns;
        makingMore();

    }

    public void makingMore()
    {
            for(int i = turns; i > 0; i--)
            {
            currentball = Instantiate(ball, ball.GetComponent<DrawLine>()._initialPosition, Quaternion.identity);
            }

    }

}

