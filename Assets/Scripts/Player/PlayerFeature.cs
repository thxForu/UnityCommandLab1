using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerFeature : MonoBehaviour
{

    //Death by thorns
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Thorns")){
            GameEvents.current.ChangeHealth();
            if(Health.healthCount > 0){
            GameEvents.current.RestartLevel();
            }
        }

        if(other.gameObject.CompareTag("Princess")){
            GameEvents.current.InTouchPrincess();
        }
    }

}
