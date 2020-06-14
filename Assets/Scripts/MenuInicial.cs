using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Iniciar() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void TelaSobre()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Sobre");
    }

    public void SairJogo() {

        Application.Quit();
    
    }

    public void VoltarMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
    }


    public void Contorles()
    {

    }
}
