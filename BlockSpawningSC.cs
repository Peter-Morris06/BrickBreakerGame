using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawningSC : MonoBehaviour
{
    public GameObject block;
    GameObject currentBlock;
    public bool spawnTime;
    


    void Start()
    {
        
    }

    void Update()
    {


        if (spawnTime == true)
        {
            for (int i = Random.Range(0, 12); i < 12; i++)
            {
                currentBlock = Instantiate(block, new Vector3(((Random.Range(-6, 6)) * 2 + 1), 11f, -2f), Quaternion.identity);               
            }
            spawnTime = false;
        }
            
                
    }
}
