using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFake : MonoBehaviour
{
    SpriteRenderer sprite;
    GameObject catfake;

    private void Awake()
    {
        sprite= GetComponent<SpriteRenderer>();
        catfake = GameObject.FindGameObjectWithTag("CatFake");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sprite.enabled = true;
        catfake.SetActive(false);
    }


}
