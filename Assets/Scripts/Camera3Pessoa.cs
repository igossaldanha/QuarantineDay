using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Camera3Pessoa : MonoBehaviour
{
    public GameObject cabeca;

    public GameObject[] posicoes;
    public int indise = 0;
    public float velocidadeMovimenoto = 2;
    private RaycastHit hit;

    void FixedUpdate()
    {

        transform.LookAt(cabeca.transform);
        //Chekcar se tem colisor

        if (!Physics.Linecast(cabeca.transform.position, posicoes[indise].transform.position))
        {
            transform.position = Vector3.Lerp(transform.position, posicoes[indise].transform.position, velocidadeMovimenoto * Time.deltaTime);
            Debug.DrawLine(cabeca.transform.position, posicoes[indise].transform.position);
        }
        else if (Physics.Linecast(cabeca.transform.position, posicoes[indise].transform.position, out hit)){
            transform.position = Vector3.Lerp(transform.position, hit.point, (velocidadeMovimenoto * 2) * Time.deltaTime);
            Debug.DrawLine(cabeca.transform.position, hit.point);


        }
    }

    void Update()
    {

        if (ConfigPause.pause) return ;


        if (Input.GetKeyDown("v") && indise < (posicoes.Length - 1)) {

            indise++;

        }
        else if (Input.GetKeyDown("v") && indise >= (posicoes.Length - 1))
        {

            indise = 0;

        }



    }

}

