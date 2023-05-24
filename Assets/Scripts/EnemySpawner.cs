using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject monsterPrefab;
    int monstersSpawned = 0;
    public static bool mustSpawn;
    // Start is called before the first frame update
    void Start()
    {
        EnemyHealth.killCount = 0;
        EnemyControlScript.moveSpeed = 4f;
        mustSpawn = true;
        InvokeRepeating("spawnAMonster", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnAMonster()
    {
        if (mustSpawn)
        {
            int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            Instantiate(monsterPrefab, spawnPoints[randomSpawnPoint].position, transform.rotation);
            monstersSpawned++;
        }
        if (monstersSpawned == 10)
        {
            EnemyControlScript.moveSpeed += 2f;
            monstersSpawned = 0;
        }
    }
}
