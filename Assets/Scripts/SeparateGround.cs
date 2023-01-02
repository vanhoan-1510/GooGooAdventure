using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeparateGround : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(SetGroundSeparate(3f));

    }

    private IEnumerator SetGroundSeparate(float delay)
    {
        yield return new WaitForSeconds(delay);
        animator.Play("groundtransform");
        animator.Play("groundtransform1");
    }

}
