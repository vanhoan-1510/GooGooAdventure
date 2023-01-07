using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boom : MonoBehaviour
{

    Animator animator;
    private PlayerMovement player;

    private void Start()
    {
        player = GameManager.Instance.player;
        animator = GetComponent<Animator>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
          StartCoroutine(Explosion(3f));
    }

    private IEnumerator Explosion(float delay)
    {
        yield return new WaitForSeconds(delay);
        AudioManager.Instance.PlaySFX("Explosion");
        animator.SetTrigger("explosion");
        PlayerMovement.Instance.Die();
    }
}
