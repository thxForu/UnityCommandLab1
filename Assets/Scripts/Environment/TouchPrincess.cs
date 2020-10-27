using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchPrincess : MonoBehaviour
{

    public Text congratText;
    // Start is called before the first frame update
    void Start()
    {
        congratText = GameObject.Find("Congrat").GetComponent<Text>();
        GameEvents.current.inTouchPrincess +=InTouchPrincess;
    }

    private void InTouchPrincess(){
        congratText.text = "";
        congratText.text = "You Won!";
    }
}
