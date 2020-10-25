using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorByButton : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        GameEvents.current.Open(id);
        gameObject.GetComponent<Collider>().enabled = false;
    }
}
