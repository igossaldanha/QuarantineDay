using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarraDia : MonoBehaviour
{
    public Image barraDiaUI;
    private float HoraMaximo = 480;
    static public float HoraAtual;

    void Start()
    {
        HoraAtual = HoraMaximo;
    }

    void Update()
    {

        if (HoraAtual >= HoraMaximo)
        {
            HoraAtual = HoraMaximo;
        }

        barraDiaUI.rectTransform.sizeDelta = new Vector2(HoraAtual / HoraMaximo * 120, 12);
        HoraAtual -= Time.deltaTime;

        if (HoraAtual < 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Ganhou");
        }
    }
}

