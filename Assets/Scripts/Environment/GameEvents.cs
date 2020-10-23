using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    // Start is called before the first frame update
    private void Awake() 
    {
        current = this;    
    }

    public event Action<int> openDoor;
    public void Open(int id){
        if(openDoor != null){
            openDoor(id);
        }
    }
}
