using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject zombiePrefab;
    

    private float XLimit = 8.5f;
    private float spawnPosY = 1;
    private float spawnPosZ = 10.5f;

    private float startDelay = 1;
    private float spawnInterval;

    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(3);
        //spawnInterval = Random.Range(1, 3);
        //InvokeRepeating("SpawnZombieLow", startDelay, spawnInterval);
    }

    Vector3 GenerateSpawnPosition()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-XLimit, XLimit), spawnPosY, spawnPosZ);

        return spawnPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(zombiePrefab, GenerateSpawnPosition(), zombiePrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
