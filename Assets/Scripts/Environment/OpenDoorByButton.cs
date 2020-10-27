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
        StartCoroutine(CoroutineSample());
    }

    private IEnumerator CoroutineSample(){
        LeanTween.moveLocalY(gameObject,7.15f,2).setEaseOutQuad();
        yield return null;
    }
}
