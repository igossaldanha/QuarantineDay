using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PersonagenWalk : MonoBehaviour
{

    public float rotacionar = 200;
    private Animator _animator;
    private float _andar = 0;
    private int _danca = 0;
    private int _flexao = 0;

    void Start()
    {

        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (ConfigPause.pause) return;


        _andar = Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.F))
        {
            _flexao += 1;

        }if (Input.GetKey(KeyCode.G))
        {
            _flexao += -1;
        }

        if (Input.GetKey(KeyCode.K))
        {
            _danca += 1;
        }

        if (Input.GetKey(KeyCode.L))
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

        _animator.SetInteger("Flexao", _flexao);

        _animator.SetInteger("Danca", _danca);
        _animator.SetFloat("Andar", _andar);
        this.transform.Rotate(0, (Input.GetAxis("Horizontal") * rotacionar) * Time.deltaTime, 0);
       
    }
}
