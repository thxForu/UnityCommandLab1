using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelFall : MonoBehaviour
{
    Rigidbody rigidBody;
    public float sec;
    
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(CorouitineSample());
        }
    }

    private IEnumerator CorouitineSample(){
        yield return new WaitForSeconds(sec);
        FallDown();
    }

    private void FallDown(){
        rigidBody.isKinematic = false;
    }
}
