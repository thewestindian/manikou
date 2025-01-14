using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosY = 20;
    public float startDelay = 2;
    public float spawnInterval = 10.0f;
    private Damage damageScript;
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        //damageScript = GameObject.Find("Vehicle").GetComponent<Damage>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        if (damageScript.gameOver == false)
        
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosY);
        
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame(int difficulty)
    {
        spawnInterval /= difficulty;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        damageScript = GameObject.Find("Vehicle").GetComponent<Damage>();
        titleScreen.gameObject.SetActive(false);
    }
}
