using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Image barraVidaUI;
    private float vidaMaximo = 60;
    static public float vidaAtual;
    
    void Start()
    {
        vidaAtual = vidaMaximo;   
    }

    void Update() {

        if (vidaAtual >= vidaMaximo) {
            vidaAtual = vidaMaximo;
        }

        barraVidaUI.rectTransform.sizeDelta = new Vector2(vidaAtual / vidaMaximo * 120, 12);
        vidaAtual -= Time.deltaTime;

        if (vidaAtual < 0)
        { 
            UnityEngine.SceneManagement.SceneManager.LoadScene("Perdeu");
        }
      
    }
}
