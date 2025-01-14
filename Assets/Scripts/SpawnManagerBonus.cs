using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerBonus : MonoBehaviour
{
    public GameObject[] bonusPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosY = 20;
    public float startDelay = 2;
    public float spawnInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SpawnRandomBonus()
    {
        int bonusIndex = Random.Range(0, bonusPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosY);
        
        Instantiate(bonusPrefabs[bonusIndex], spawnPos, bonusPrefabs[bonusIndex].transform.rotation);
    }

    public void StartGameBonus()
    {
        InvokeRepeating("SpawnRandomBonus", startDelay, spawnInterval);
    }

}

