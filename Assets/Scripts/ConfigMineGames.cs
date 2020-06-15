using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigMineGames : MonoBehaviour
{
    public GameObject menuPause;
    static public bool pause;

    void Start()
    {

        menuPause = Instantiate(menuPause, menuPause.transform.position, menuPause.transform.rotation) as GameObject;
        Pause(false);

    }

    void Pause(bool statusPause)
    {

        pause = statusPause;
        menuPause.SetActive(pause);
        if (pause == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {

            Pause(!pause);
        }

    }
}
