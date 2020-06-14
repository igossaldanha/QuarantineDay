using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Playables;

public class PersonagenWalk : MonoBehaviour
{

    public AudioSource somPassos;

    public PlayableDirector introCutScene;

    public float rotacionar = 200;
    private Animator _animator;
    private float _andar = 0;
    private int _danca = 0;
    private int _flexao = 0;
    private int _sentar = 0;
    private int _abdominal = 0;

    private bool canControl;

    void Start()
    {
        Invoke("habilitarControlles", (float)introCutScene.duration);
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!canControl)
        {
            return;
        }

        if (ConfigPause.pause) return;


        _andar = Input.GetAxis("Vertical");


        
        if (Input.GetKey(KeyCode.B)) //Sentar
        {
            _abdominal += 1;

        }
        if (Input.GetKey(KeyCode.N)) //Levantar
        {
            _abdominal += -1;
        }

        

        if (Input.GetKey(KeyCode.F)) // fazer flexão
        {
            _flexao += 1;

        }if (Input.GetKey(KeyCode.G)) // Parar Flexão
        {
            _flexao += -1;
        }

        if (Input.GetKey(KeyCode.K)) // Dançar
        {
            _danca += 1;
        }

        if (Input.GetKey(KeyCode.L)) // Parar de dançar
        {
            _danca += -1;
        }


        if (Input.GetKey(KeyCode.LeftShift))
        {
            _andar += 1;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _andar = 1;
        }


        // Controle de animações
        _animator.SetInteger("Abdominal", _abdominal);
        _animator.SetInteger("Sentar", _sentar);
        _animator.SetInteger("Flexao", _flexao);
        _animator.SetInteger("Danca", _danca);
        _animator.SetFloat("Andar", _andar);

        // Movimentar a camera

        if (_danca == 0 || _flexao == 0 || _sentar == 0 || _abdominal == 0) { 
        
        this.transform.Rotate(0, (Input.GetAxis("Horizontal") * rotacionar) * Time.deltaTime, 0);

        }
       
    }

    public void SondPassos() {

        somPassos.Play();
    
    }

    public void desabilitarControlles() {

        canControl = false;
    
    }
    public void habilitarControlles()
    {

        canControl = true;

    }

}
