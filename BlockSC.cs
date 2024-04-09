using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSC : MonoBehaviour
{
    public BoxCollider2D BlockCollider;
    public GameObject block;
    private Vector3 BlockPosistion;
    public bool moveForward;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        BlockPosistion = block.transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ballTag")
        {
            Object.Destroy(block);
        }
        if (collision.gameObject.tag == "blockTag")
        {
            Object.Destroy(block);
        }
    }
    public void Movingforward()
    {
        if (moveForward == true)
        {
            BlockPosistion.y -= 4;
            moveForward = false;
            
        }
        //GameObject.Find("Ball").GetComponent<throwingSC>().canThrow == true
    }

}
