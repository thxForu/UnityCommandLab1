using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCount : MonoBehaviour
{
    private Text healthCountText;

    private Text loseText;
    // Start is called before the first frame update

    void Start()
    {
        healthCountText = GetComponent<Text>();

        loseText = GameObject.Find("Lose").GetComponent<Text>();

        ShowHealth();

        GameEvents.current.changeHealth +=ChangeHealth;
    }

    private void ChangeHealth(){
        Health.healthCount--;
        ShowHealth();
        if(Health.healthCount == 0){
            loseText.text = Health.loseText;
            loseText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void ShowHealth(){
        healthCountText.text = "";
        for (int i = 0; i < Health.healthCount; i++)
        {
            healthCountText.text += "❤️";
        }
    }
}
