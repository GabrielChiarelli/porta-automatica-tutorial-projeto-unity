using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    private Rigidbody2D oRigidbody2D;

    private const float velocidadeDoJogador = 5f;
    private Vector2 inputsDeMovimento;

    private void Start()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ReceberInputs();
    }

    private void FixedUpdate()
    {
        MovimentarJogador();
    }

    private void ReceberInputs()
    {
        inputsDeMovimento = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void MovimentarJogador()
    {
        oRigidbody2D.velocity = inputsDeMovimento.normalized * velocidadeDoJogador;
    }
}
