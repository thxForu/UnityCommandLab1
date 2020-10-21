using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFeature : MonoBehaviour
{
    //Death by thorns
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Thorns")){
            Destroy(gameObject);
            Debug.Log("dead");
        }
    }
}
