using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject zombie;
    public Terrain terrain;
    public int alpha;
    public int beta;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DaySpawn();
        }

    }


    void DaySpawn()
    {
        for(int i=0;i<500;i++)
        {
            int x = Random.Range(2, 365);
            float z = Random.Range(3, 485);
            terrain.terrainData.GetHeight(x, beta);

            Vector3 v = new Vector3(x, beta, z);
            Instantiate(zombie, v, transform.rotation);
        }

    }





}
