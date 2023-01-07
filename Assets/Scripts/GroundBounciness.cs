using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GroundBounciness : MonoBehaviour
{

    private Animator animator;
    private int count;
    BoxCollider2D boxCollider;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(SetGroundBounciness(0.3f));
    }

    private IEnumerator SetGroundBounciness(float delay)
    {
        animator.Play("GroundAnimation");
        yield return new WaitForSeconds(delay);
        boxCollider.enabled= false;
    }

}
