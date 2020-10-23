using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorByButton : MonoBehaviour
{
    // public GameObject obj;
    // // public Transform target;
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        GameEvents.current.Open(id);
    }

    // void Start()
    // {
    //     obj  = GameObject.Find("Door");
    // }

    // IEnumerator MoveUp()
    // {
    // }

}
