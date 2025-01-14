using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserNameOutput : MonoBehaviour
{

public static UserNameOutput Instance;

private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
