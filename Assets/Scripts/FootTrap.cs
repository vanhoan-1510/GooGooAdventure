using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootTrap : MonoBehaviour
{

    Animator animator;


    private void Start()
    {
        animator= GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.Play("footicondisplay");
        animator.Play("footanim");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.Play("foottrap");
        AudioManager.Instance.PlaySFX("Punch");
    }

}
