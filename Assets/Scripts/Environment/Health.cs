using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public static int healthCount = 4;

    public static string loseText = "You Lose";

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

}
