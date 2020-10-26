using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public int id;
    void Start()
    {
        GameEvents.current.openDoor += Open;
    }

    private void Open(int id)
    {
        if(id == this.id)
        {
            LeanTween.moveLocalY(gameObject,12f,2).setEaseOutQuad();
        }
    }

}
