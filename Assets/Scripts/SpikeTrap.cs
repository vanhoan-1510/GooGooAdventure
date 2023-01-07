using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    SpriteRenderer sprite;
    GameObject wall1;
    GameObject wall2;
    // Start is called before the first frame update
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        wall1 = GameObject.FindGameObjectWithTag("WallTrap1");
        wall2 = GameObject.FindGameObjectWithTag("WallTrap2");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sprite.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        wall1.transform.position = new Vector3(35f, 1f, 0);
        wall2.transform.position = new Vector3(38f, 1f, 0);
    }

}
