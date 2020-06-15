﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

public class CutSceneAtivador : MonoBehaviour
{

    public PlayableDirector cutScene;
    public bool playerOnTrigger;
    private bool playerIsTrigger;
    private bool alreadyPLayed;

    //public UnityEvent onPlay;
    //public UnityEvent onStop;

    public GameObject canvas;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {

        if (playerIsTrigger) {

            if (Input.GetKey(KeyCode.E)){
                StartCutScene();

                if (canvas != null)
                {
                    canvas.SetActive(false);
                }

            }


        }

    }

    
    void StartCutScene() {

       // if (alreadyPLayed)
       //     return;

        alreadyPLayed = true;
       // onPlay.Invoke();
        cutScene.Play();
       // Invoke("FinishCutScene", (float)cutScene.duration);

    }

    void FinishCutScene() {

      //  onStop.Invoke();
    
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {

            playerIsTrigger = true;

            if (canvas != null) {
                canvas.SetActive(true); 
            }

          //  if (playerOnTrigger) {
            //    StartCutScene();
           // }
        
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (canvas != null)
            {
                canvas.SetActive(false);
            }

            playerIsTrigger = false;

           // if (playerOnTrigger)
         //   {

          //  }

        }
    }
}