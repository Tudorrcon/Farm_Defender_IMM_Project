using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyHighPrefab;
    public GameObject enemyLowPrefab;
    public GameObject powerupPrefab;

    private float XLimit = 8.5f;
    private float spawnPosY = 1;
    private float spawnPosZ = 10.5f;

    private float XLimit2 = 8.0f;
    private float spawnPosY2 = 1;
    private float ZLimit = 15.0f;

    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        powerupPrefab.SetActive(true);
        SpawnEnemyWave(waveNumber);
    }

    Vector3 GenerateSpawnPosition()
    {
        Vector3 randomSpawnPos = new Vector3(Random.Range(-XLimit, XLimit), spawnPosY, spawnPosZ);
        return randomSpawnPos;
    }

    Vector3 GeneratePowerUpSpawnPosition()
    {
        Vector3 randomSpawnPos = new Vector3(Random.Range(-XLimit2, XLimit2), spawnPosY2, Random.Range(-ZLimit,ZLimit));
        return randomSpawnPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyLowPrefab, GenerateSpawnPosition(), enemyLowPrefab.transform.rotation);
        }

        if(enemiesToSpawn == 3)
        {
            Instantiate(powerupPrefab, GeneratePowerUpSpawnPosition(), powerupPrefab.transform.rotation);
        }
        else if(enemiesToSpawn == 6)
        {
            Instantiate(powerupPrefab, GeneratePowerUpSpawnPosition(), powerupPrefab.transform.rotation);
        }
        else if(enemiesToSpawn == 9)
        {
            Instantiate(powerupPrefab, GeneratePowerUpSpawnPosition(), powerupPrefab.transform.rotation);
        }

        
       
        
        if (enemiesToSpawn > 7 && enemiesToSpawn <10)
        {
            Instantiate(enemyHighPrefab, GenerateSpawnPosition(), enemyHighPrefab.transform.rotation);
        }
        else if (enemiesToSpawn > 9)
        {
            Instantiate(enemyHighPrefab, GenerateSpawnPosition(), enemyHighPrefab.transform.rotation);
            Instantiate(enemyHighPrefab, GenerateSpawnPosition(), enemyHighPrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyLow>().Length + FindObjectsOfType<EnemyHigh>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            if (waveNumber > 0 && waveNumber < 5)
            {
                enemyLowPrefab.GetComponent<EnemyLow>().speed = 10;
            }
            else if (waveNumber > 4 && waveNumber < 10)
            {
                enemyLowPrefab.GetComponent<EnemyLow>().speed = 10;
                enemyHighPrefab.GetComponent<EnemyHigh>().speed = 3;
            }
            else
            {
                enemyLowPrefab.GetComponent<EnemyLow>().speed = 10;
                enemyHighPrefab.GetComponent<EnemyHigh>().speed = 13;
            }
            SpawnEnemyWave(waveNumber); 
        }

        
    }
}
