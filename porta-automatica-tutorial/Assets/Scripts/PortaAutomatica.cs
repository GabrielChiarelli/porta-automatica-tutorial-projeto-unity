using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaAutomatica : MonoBehaviour
{
    private Animator oAnimator;

    private void Start()
    {
        oAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<MovimentoDoJogador>() != null)
        {
            oAnimator.Play("porta-abrindo");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<MovimentoDoJogador>() != null)
        {
            oAnimator.Play("porta-fechando");
        }
    }
}
