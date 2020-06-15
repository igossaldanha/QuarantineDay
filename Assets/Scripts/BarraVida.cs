using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Image barraVidaUI;
    private float vidaMaximo = 120;
 
    static public float vidaAtual;
    //static public float tempo;
    
    // Start is called before the first frame update
    void Start()
    {
        vidaAtual = vidaMaximo;   
    }

    // Update is called once per frame
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
