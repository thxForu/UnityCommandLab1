using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCount : MonoBehaviour
{

    public int healthCount = 4;
    private Text healthCountText;
    // Start is called before the first frame update
    void Start()
    {
        healthCountText = GetComponent<Text>();

        ShowHealth();

        GameEvents.current.changeHealth +=ChangeHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            ChangeHealth();
        }        
    }

    private void ChangeHealth(){
        healthCount--;
        ShowHealth();       
    }

    private void ShowHealth(){
        healthCountText.text = "";
        for (int i = 0; i < healthCount; i++)
        {
            healthCountText.text += "❤️";
        }
    }
}
