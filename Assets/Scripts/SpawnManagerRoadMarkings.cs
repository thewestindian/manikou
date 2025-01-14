using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerRoadMarkings : MonoBehaviour
{
    public GameObject[] roadMarkingsPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosY = 20;
    public float startDelay = 2;
    public float spawnInterval = 1.0f;
    private Damage damageScript;
    public bool isRoadMarkingsSpawnerActive;
    public GameObject audioSourceEngine;

    // Start is called before the first frame update
    void Start()
    {
        isRoadMarkingsSpawnerActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRoadMarkingsSpawnerActive == true)
        {
            audioSourceEngine.gameObject.SetActive(true);
            damageScript.UpdateDistance(0);
        }
        
        if (isRoadMarkingsSpawnerActive == false)
        {
            audioSourceEngine.gameObject.SetActive(false);
        }

    }

    void SpawnRandomRoadMarkings()
    {
        if (damageScript.gameOver == false)
        {
        isRoadMarkingsSpawnerActive = true;
        int roadMarkingsIndex = Random.Range(0, roadMarkingsPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosY);
        
        Instantiate(roadMarkingsPrefabs[roadMarkingsIndex], spawnPos, roadMarkingsPrefabs[roadMarkingsIndex].transform.rotation);
        }
        if (damageScript.gameOver == true)
        {
            isRoadMarkingsSpawnerActive = false;
        }
    }

public void StartGameRoadMarkings()
    {
        InvokeRepeating("SpawnRandomRoadMarkings", startDelay, spawnInterval);
        damageScript = GameObject.Find("Vehicle").GetComponent<Damage>();
    }

}
