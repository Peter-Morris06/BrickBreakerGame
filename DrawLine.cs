using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    public GameObject ball;
    
    public bool canthrow;

    public int numTurns;



    public void Start()
    {
        _lineRenderer = gameObject.AddComponent<LineRenderer>();
        _lineRenderer.SetWidth(0.2f, 0.2f);
        _lineRenderer.enabled = false;
        canthrow = true;
    }

    public Vector3 _initialPosition;
    private Vector3 _currentPosition;

    public void Update()
    {

        if (canthrow == true)
        {
            ball.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            if (Input.GetMouseButtonDown(0))
            {
                _initialPosition = ball.transform.position;
                _lineRenderer.SetPosition(0, _initialPosition);
                _lineRenderer.SetVertexCount(1);
                _lineRenderer.enabled = true;
            }
            else if (Input.GetMouseButton(0))
            {
                _currentPosition = GetCurrentMousePosition().GetValueOrDefault();
                _lineRenderer.SetVertexCount(2);
                _lineRenderer.SetPosition(1, _currentPosition);

            }
            else if (Input.GetMouseButtonUp(0))
            {
                _lineRenderer.enabled = false;
                var releasePosition = GetCurrentMousePosition().GetValueOrDefault();
                var direction = releasePosition - _initialPosition;


                ball.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                ball.GetComponent<Rigidbody2D>().velocity = direction * 5;
                Debug.Log("Process direction " + direction);
                canthrow = false;
                numTurns++;
            }
        }
    }

    private Vector3? GetCurrentMousePosition()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var plane = new Plane(Vector3.forward, Vector3.zero);

        float rayDistance;
        if (plane.Raycast(ray, out rayDistance))
        {
            return ray.GetPoint(rayDistance);

        }

        return null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ThrowPoint")
        {
            ball.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            _initialPosition =  ball.GetComponent<Rigidbody2D>().position;
            canthrow = true;
             
        }
    }

}
