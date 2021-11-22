using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject zombiePrefab;

    private float XLimit = 8.5f;
    private float spawnPosY = 1;
    private float spawnPosZ = 10.5f;

    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    Vector3 GenerateSpawnPosition()
    {
        Vector3 randomSpawnPos = new Vector3(Random.Range(-XLimit, XLimit), spawnPosY, spawnPosZ);

        return randomSpawnPos;
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
        enemyCount = FindObjectsOfType<EnemyLow>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            if (waveNumber > 4 && waveNumber < 10)
            {
                zombiePrefab.GetComponent<EnemyLow>().speed = 10;
            }
            else if (waveNumber > 9)
            {
                zombiePrefab.GetComponent<EnemyLow>().speed = 15;
            }
            else
            {
                zombiePrefab.GetComponent<EnemyLow>().speed = 5;
            }
            SpawnEnemyWave(waveNumber);
        }

        
    }
}
