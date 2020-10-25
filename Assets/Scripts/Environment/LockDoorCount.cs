using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockDoorCount : MonoBehaviour
{
    private int lockDoorCount;
    private Text lockDoorCountText;
    void Start()
    {
        lockDoorCountText = GetComponent<Text>();
        GameEvents.current.openDoor += Open;
        GameObject[] ldc = GameObject.FindGameObjectsWithTag("Door");
        lockDoorCount = ldc.Length;
        lockDoorCountText.text = lockDoorCount.ToString();
    }

    private void Open(int id){
        lockDoorCountText.text = (--lockDoorCount).ToString();
    }
}
