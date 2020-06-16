using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ConfigPause : MonoBehaviour
{
    public GameObject menuPause;
    static public bool pause;

    void Start()
    {
        
       menuPause = Instantiate(menuPause, menuPause.transform.position, menuPause.transform.rotation) as GameObject;
        Pause(false);   
    
    }

    void Pause(bool statusPause) {

        pause = statusPause;
        menuPause.SetActive(pause);
        if (pause == true)
        {
            Time.timeScale = 0;
        }
        else {

            Time.timeScale = 1;
        }
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.P)){

            Pause(!pause);
        }

    }
}
