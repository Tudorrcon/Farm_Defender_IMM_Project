using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject zombiePrefab;

    private float spawnLimitZLeft = 4;
    private float spawnLimitZRight = -14;
    private float spawnPosY = 1;

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
        
        Vector3 spawnPos = new Vector3(-6, spawnPosY,  Random.Range(spawnLimitZLeft, spawnLimitZRight));

        // instantiate zombie at random spawn location
        Instantiate(zombiePrefab, spawnPos, zombiePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
