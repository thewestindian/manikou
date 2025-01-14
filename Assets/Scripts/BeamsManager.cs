using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BeamsManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI savedText;
    public int saved;

    private Damage damage;
    void Start()
    {
        
        savedText.text = " " + saved;
        saved = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("HEADLIGHTS OFF");
            saved ++;
            savedText.text = " " + saved;
            gameObject.SetActive(false);
            damage.isBeamsActive = false;
            
        }
    }
}
