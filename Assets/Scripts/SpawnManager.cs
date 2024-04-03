using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] projectiles;
    public float startDelay = 1.0f;
    public float xRange = 9;
    public float zPos = 30;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnProjectile", startDelay, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnProjectile()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 0.7f, zPos);
        
        Instantiate(projectiles[Random.Range(0, projectiles.Length)], spawnPos, projectiles[0].transform.rotation);
    }
}

