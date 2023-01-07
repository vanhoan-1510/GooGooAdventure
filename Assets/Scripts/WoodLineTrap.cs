using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WoodLineTrap : MonoBehaviour
{
    private CapsuleCollider2D capsuleCollider2D;
    private int count = 1;
    private void Start()
    {
        capsuleCollider2D = gameObject.GetComponent<CapsuleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (count == 1)
        {
            capsuleCollider2D.transform.Rotate(0f, 0f, 90f, Space.Self);
            count--;
        }
    }
}
