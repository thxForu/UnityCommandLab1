using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelFall : MonoBehaviour
{
    Rigidbody rigidBody;
    public float sec;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        StartCoroutine(CorouitineSample());
    }

    public IEnumerator CorouitineSample(){
        yield return new WaitForSeconds(sec);
        FallDown();
    }

    private void FallDown(){
        rigidBody.isKinematic = false;
    }
}
