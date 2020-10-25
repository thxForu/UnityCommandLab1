using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCount : MonoBehaviour
{
    private Text healthCountText;

    public GameObject canvas;
    // Start is called before the first frame update

    void Start()
    {
        healthCountText = GetComponent<Text>();

        ShowHealth();

        GameEvents.current.changeHealth +=ChangeHealth;
    }

    private void ChangeHealth(){
        Health.healthCount--;
        ShowHealth();       
    }

    private void ShowHealth(){
        healthCountText.text = "";
        for (int i = 0; i < Health.healthCount; i++)
        {
            healthCountText.text += "❤️";
        }
    }
}
