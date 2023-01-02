using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform playerPos;
    private void Awake()
    {
        playerPos = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = Mathf.Max(cameraPosition.x, playerPos.position.x);
        transform.position = cameraPosition;

        if(playerPos.position.y >= 2.5f)
        {
            cameraPosition.y = Mathf.Max(cameraPosition.y, playerPos.position.y);
            transform.position = cameraPosition;
        }
    }
}
