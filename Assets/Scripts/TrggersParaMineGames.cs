using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrggersParaMineGames : MonoBehaviour
{
    public bool playerOnTrigger;
    private bool playerIsTrigger;
   // public GameObject objeto;
    public GameObject canvas;

  //  private bool alreadyPLayed;


    //Objetos desativdos
    public GameObject CanvasDeBarras;
    public GameObject player;
    public GameObject casa;
    public GameObject concertosCasa;
   // public GameObject MusicaDeFundo;
    
    static public bool GameFinish;

    public GameObject PacMan;
    private bool pacMan;

    
    // Start is called before the first frame update
    void Start()
    {
        GameFinish = false;
        PacMan = Instantiate(PacMan, PacMan.transform.position, PacMan.transform.rotation) as GameObject;
        Jogando(false);

    }

    private void FixedUpdate()
    {
        if (GameFinish == true) {
            //Jogando(false);
            pacMan = false;
            Jogando(pacMan);
            CanvasDeBarras.SetActive(!pacMan);
            player.SetActive(!pacMan);
            casa.SetActive(!pacMan);
            concertosCasa.SetActive(!pacMan);
        }
    }

    void Jogando(bool statusJogo)
    {

        pacMan = statusJogo;
        PacMan.SetActive(pacMan);

        if (pacMan == true)
        {
            //Time.timeScale = 0;
        }
        else
        {
            //Time.timeScale = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (playerIsTrigger)
        {

            if (Input.GetKey(KeyCode.E))
            {
              //  alreadyPLayed = true;
                Jogando(!pacMan);
                


                //MusicaDeFundo.SetActive(!PacMan);
                CanvasDeBarras.SetActive(!pacMan);
                player.SetActive(!pacMan);
                casa.SetActive(!pacMan);
                concertosCasa.SetActive(!pacMan);
                //PacMan.SetActive(pacMan);
               // objeto.SetActive(false);
                
                if (canvas != null)
                {
                    canvas.SetActive(false);
                }

            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            playerIsTrigger = true;

            if (canvas != null)
            {
                canvas.SetActive(true);
            }

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

        }
    }
}
