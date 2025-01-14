using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    
    private Button button;
    private SpawnManager spawnManager;
    private SpawnManagerRoadMarkings spawnManagerRoadMarkings;
    private SpawnManagerBonus spawnManagerBonus;
    private SpawnManagerHeadlights spawnManagerHeadlights;
    public int difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        spawnManagerRoadMarkings = GameObject.Find("SpawnManagerRoadMarkings").GetComponent<SpawnManagerRoadMarkings>();
        spawnManagerBonus = GameObject.Find("SpawnManagerBonus").GetComponent<SpawnManagerBonus>();
        spawnManagerHeadlights = GameObject.Find("SpawnManagerHeadlights").GetComponent<SpawnManagerHeadlights>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        spawnManager.StartGame(difficulty);
        spawnManagerRoadMarkings.StartGameRoadMarkings();
        spawnManagerBonus.StartGameBonus();
        spawnManagerHeadlights.StartGameHeadlights();

    }
}
