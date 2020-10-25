using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerFeature : MonoBehaviour
{

    private void Start() {
    }
    //Death by thorns
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Thorns")){
            GameEvents.current.RestartLevel();
            GameEvents.current.ChangeHealth();
        }
    }

}
