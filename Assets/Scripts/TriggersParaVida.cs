using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersParaVida : MonoBehaviour
{
   // public AudioSource somComida;

    public bool playerOnTrigger;
    private bool playerIsTrigger;
    public GameObject objeto;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (playerIsTrigger)
        {

            if (Input.GetKey(KeyCode.E))
            {

                objeto.SetActive(false);

                BarraVida.vidaAtual += 20f;
              //  SomComida();

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

    /*
    public void SomComida()
    {
        somComida.Play();
    }
    */

}
