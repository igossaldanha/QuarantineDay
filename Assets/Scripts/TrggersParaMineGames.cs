using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrggersParaMineGames : MonoBehaviour
{
    // Dados de presença no Colisor
    public bool playerOnTrigger;
    private bool playerIsTrigger;

    // Canvas com o detalhe(nome) da ação a ser execultada
    public GameObject canvas;

    //Objetos desativdos
    public GameObject CanvasDeBarras;
    public GameObject player;
    public GameObject casa;
    public GameObject concertosCasa;
    public GameObject MainCamera;
    
    // Verificador de finalização
    static public bool GameFinish;

    // Ativadores dos minegames
    public GameObject MineGame;
    private bool modificador;

    void Start()
    {
        GameFinish = false;
        MineGame = Instantiate(MineGame, MineGame.transform.position, MineGame.transform.rotation) as GameObject;
        Jogando(false);
    }


    private void FixedUpdate()
    {
        // Verificar se o minegame foi concluido
        if (GameFinish == true) {

            modificador = false;
            Jogando(modificador);
            CanvasDeBarras.SetActive(!modificador);
            player.SetActive(!modificador);
            casa.SetActive(!modificador);
            concertosCasa.SetActive(!modificador);
            MainCamera.SetActive(!modificador);
        }
    }

    // Ativar a Instancia do minegame em tela
    void Jogando(bool statusJogo)
    {

        modificador = statusJogo;
        MineGame.SetActive(modificador);

    }

    void Update()
    {
        // Verificar se esta colidindo
        if (playerIsTrigger)
        {

            if (Input.GetKey(KeyCode.E))
            {

                Jogando(!modificador);                
                CanvasDeBarras.SetActive(!modificador);
                player.SetActive(!modificador);
                casa.SetActive(!modificador);
                concertosCasa.SetActive(!modificador);
                MainCamera.SetActive(!modificador);

                if (canvas != null)
                {
                    canvas.SetActive(false);
                }

            }
        }

    }

    // Esta colidindo
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

    // Não esta colidindo
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
