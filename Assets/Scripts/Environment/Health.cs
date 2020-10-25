using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public static int healthCount = 4;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

}
