using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.restartLevel +=RestartLevel;
    }

    private void RestartLevel(){
        SceneManager.LoadScene( SceneManager.GetActiveScene().name,LoadSceneMode.Single );
    }


}
