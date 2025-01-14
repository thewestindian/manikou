using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    //public int saved;
    public int life;
    public float distance;
    public float distanceToAdd = 0.00f;
    public bool gameOver = false;
    public bool isRoadMarkingsSpawnerActive;
    public bool isBeamsActive;

    public AudioClip bonusSound;
    private AudioSource bonusAudio;
    public AudioClip obstacleSound;
    private AudioSource obstacleAudio;
    //private AudioClip carSound;
    //public AudioSource carAudio;
    
    public TextMeshProUGUI scoreText;
    //public TextMeshProUGUI savedText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI distanceText;
    public Button restartButton;
    public GameObject beams;
    public GameObject blood;
    public GameObject blood5;
    public GameObject blood4;
    public GameObject blood3;
    public GameObject blood2;
    public GameObject blood1;
    
    // Start is called before the first frame update
    void Start()
    {
        life = 5;
        distance = 0;
        scoreText.text = "lavi aw: " + life;
        bonusAudio = GetComponent<AudioSource>();
        obstacleAudio = GetComponent<AudioSource>();
        isRoadMarkingsSpawnerActive = false;
        isBeamsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
      if (life <1)
        {
            //blood2.gameObject.SetActive(false);
            blood1.gameObject.SetActive(true);
            gameOver = true;
            Debug.Log("Game Over!!!!!!");
            Destroy(gameObject);
            GameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Headlights"))
        {
            Debug.Log("HEADLIGHTS");
            beams.gameObject.SetActive(true);
            isBeamsActive = true;
        }
        
        if (other.gameObject.CompareTag("Obstacle") && (isBeamsActive == false))
        {
            life --;
            obstacleAudio.PlayOneShot(obstacleSound, 1.0f);
            scoreText.text = "lavi aw:" + (life);
        }

        if (life == 4)
        {
            blood5.gameObject.SetActive(true);
            Debug.Log("BLOOD5");
        }

        if (life == 3)
        {
            //blood5.gameObject.SetActive(false);
            blood4.gameObject.SetActive(true);
            Debug.Log("BLOOD4");
        }


        if (life == 2)
        {
            //blood5.gameObject.SetActive(false);
            //blood4.gameObject.SetActive(false);
            blood3.gameObject.SetActive(true);
            Debug.Log("BLOOD3");
        }

        if (life == 1)
        {
            //blood5.gameObject.SetActive(false);
            //blood4.gameObject.SetActive(false);
            //blood3.gameObject.SetActive(false);
            blood2.gameObject.SetActive(true);
            Debug.Log("BLOOD2");
        }

        if (other.gameObject.CompareTag("Obstacle") && (isBeamsActive == true))
        {
            isBeamsActive = false;
        }

        if (other.gameObject.CompareTag("Bonus"))
        {
            life = 5;
            bonusAudio.PlayOneShot(bonusSound, 1.0f);
            scoreText.text = "lavi aw:" + (life);
            blood5.gameObject.SetActive(false);
            blood4.gameObject.SetActive(false);
            blood3.gameObject.SetActive(false);
            blood2.gameObject.SetActive(false);
        }

        //Destroy(gameObject);
        Destroy(other.gameObject);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

    }

    public void UpdateDistance(float distanceToAdd)
    {
        distance += (Time.deltaTime+distanceToAdd) / 10;
        distanceText.text = distance + " ";
    }

}