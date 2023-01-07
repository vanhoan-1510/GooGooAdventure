using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRotateGround : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.transform.Rotate(0f, 0f, 90f, Space.Self);
    }

}
