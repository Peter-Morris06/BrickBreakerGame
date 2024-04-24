using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawningSC : MonoBehaviour
{
    public GameObject block;
    GameObject currentBlock;
    public GameObject ball;

    public bool spawnTime;
    public bool moveforwardTIME;




    void Start()
    {
        
    }

    void Update()
    {
        if(moveforwardTIME == true)
        {
            block.GetComponent<BlockSC>().Movingforward();
            moveforwardTIME = false;

        }



        if (spawnTime == true)
        {



            for (int i = Random.Range(0, 12); i < 12; i++)
            {
                currentBlock = Instantiate(block, new Vector3(((Random.Range(-6, 6)) * 2 + 1), 11f, -2f), Quaternion.identity);               
            }
            spawnTime = false;
            moveforwardTIME = true;
        }

    


    }
    
}
