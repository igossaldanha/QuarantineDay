using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easterEgg : MonoBehaviour
{
    public bool playerOnTrigger;
    private bool playerIsTrigger;

    public GameObject objeto;
    //public GameObject canvas;

    void Update()
    {

        if (playerIsTrigger)
        {
            BarraVida.vidaAtual += 30f;
            objeto.SetActive(false);

              
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsTrigger = false;
        }
    }
}
