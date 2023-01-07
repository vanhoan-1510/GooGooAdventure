using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistLeft : MonoBehaviour
{

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.Play("fistzoom");
        AudioManager.Instance.PlaySFX("Punch");
    }

}
