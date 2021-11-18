using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject zombiePrefab;

    private float spawnLimitZLeft = -23;
    private float spawnLimitZRight = 18;
    private float spawnPosY = 1;
    private float spawnPosX = -1.65f;

    private float startDelay = 1;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(1, 3);
        InvokeRepeating("SpawnZombieLow", startDelay, spawnInterval);
    }

    void SpawnZombieLow()
    {
        
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitZLeft, spawnLimitZRight), spawnPosY, spawnPosX );

        // instantiate zombie at random spawn location
        Instantiate(zombiePrefab, spawnPos, zombiePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
