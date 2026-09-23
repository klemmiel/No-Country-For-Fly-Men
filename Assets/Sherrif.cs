using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sherrif : MonoBehaviour
{
    public GameObject sherrif;
    Vector3 pos1 = new Vector3(-2, 6, 0);
    Vector3 pos2 = new Vector3(0, 6, 0);
    Vector3 pos3 = new Vector3(2, 6, 0);
    Vector3 pos4 = new Vector3(-10, 2, 0);
    Vector3 pos5 = new Vector3(-10, 0, 0);
    Vector3 pos6 = new Vector3(-10, -2, 0);
    int RandNum;
    float timer;
    float interval = 2f;

    void Update()
    {
        timer += Time.deltaTime; 
        if (timer > interval)
        {
            SpawnSherrif();
            timer = 0;
        }
    }

    void SpawnSherrif()
    {
        RandNum = Random.Range(0, 6);
        
        if (RandNum == 0 )Instantiate(sherrif, pos1, Quaternion.identity);
        if (RandNum == 1) Instantiate(sherrif, pos2, Quaternion.identity);
        if (RandNum == 2) Instantiate(sherrif, pos3, Quaternion.identity);
        if (RandNum == 3) Instantiate(sherrif, pos4, Quaternion.identity);
        if (RandNum == 4) Instantiate(sherrif, pos5, Quaternion.identity);
        if (RandNum == 5) Instantiate(sherrif, pos6, Quaternion.identity);
    }
}
