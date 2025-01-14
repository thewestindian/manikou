using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    private Damage damageScript;

    // Start is called before the first frame update
    void Start()
    {
        damageScript = GameObject.Find("Vehicle").GetComponent<Damage>();

    }

    // Update is called once per frame
    void Update()
    {
        if (damageScript.gameOver == false)
        {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
}
