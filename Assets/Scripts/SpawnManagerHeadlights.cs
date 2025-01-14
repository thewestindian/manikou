using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerHeadlights : MonoBehaviour
{
    public GameObject[] headlightsPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosY = 20;
    public float startDelay = 0;
    public float spawnInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SpawnRandomHeadlights()
    {
        int headlightsIndex = Random.Range(0, headlightsPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosY);
        
        Instantiate(headlightsPrefabs[headlightsIndex], spawnPos, headlightsPrefabs[headlightsIndex].transform.rotation);
    }

    public void StartGameHeadlights()
    {
        InvokeRepeating("SpawnRandomHeadlights", startDelay, spawnInterval);
    }

}
