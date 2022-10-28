using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] projectilePrefab;
    public float spawnRangeX = 5;
    public float startDelay = 0f;
    public float spawnInterval = 1.0f;
    public float spawnPosZ = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnStuff", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnStuff()
    {
        int projectileIndex = Random.Range(0, projectilePrefab.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2, spawnPosZ);
        Instantiate(projectilePrefab[projectileIndex], new Vector3(0, 0, 8), projectilePrefab[projectileIndex].transform.rotation);
    }
}
