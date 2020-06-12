using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagenWalk : MonoBehaviour
{

    public float rotacionar = 200;
    private Animator _animator;
    private float _andar = 0;


    void Start()
    {

        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        _andar = Input.GetAxis("Vertical");



        if (Input.GetKey(KeyCode.LeftShift))
        {
            _andar += 1;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _andar = 1;
        }


        _animator.SetFloat("Andar", _andar);
        this.transform.Rotate(0, (Input.GetAxis("Horizontal") * rotacionar) * Time.deltaTime, 0);
        Debug.Log(_andar);
    }
}
