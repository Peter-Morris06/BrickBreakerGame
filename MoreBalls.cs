using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreBalls : MonoBehaviour
{
    public GameObject ball;
    public GameObject ballprefab;
    
    public int turns;

    public List<GameObject> ballS;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        turns = ball.GetComponent<DrawLine>().numTurns;
        

    }

    public void makingMore()
    {

            for(int i = turns; i > 0; i--)
            {

            ballS.Add(Instantiate(ballprefab, ball.GetComponent<DrawLine>()._initialPosition, Quaternion.identity));
                }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        for (int i = turns; i > 0; i--)
        {
            if (collision.gameObject.tag == "ThrowPoint")
            {

                Object.Destroy(ballS[i]);
            }
        }
    }
}

