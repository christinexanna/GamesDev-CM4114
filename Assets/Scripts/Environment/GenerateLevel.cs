using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] block;
    public int zPos = 50; // block position
    public bool creatingBlock = false;
    public int blockNum;


    // Update is called once per frame
    void Update()
    {
        if (creatingBlock == false)
        {
            creatingBlock = true;
            StartCoroutine(GenerateBlock());
        }
        
    }

    IEnumerator GenerateBlock()
    {
        blockNum = Random.Range(0, 3); // randomise between 4 environment blocks
        Instantiate(block[blockNum], new Vector3(0, 0, zPos), Quaternion.identity); // new block instantiated
        zPos += 50;
        yield return new WaitForSeconds(2); // every 2 seconds new environment block will be created
        creatingBlock = false;
    }
}
