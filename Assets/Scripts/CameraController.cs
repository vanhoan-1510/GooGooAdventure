using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform playerPos;

    public Vector2 minPos;
    public Vector2 maxPos;
    private void Awake()
    {
        playerPos = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = Mathf.Max(cameraPosition.x, playerPos.position.x);
        transform.position = cameraPosition;

        cameraPosition.x = Mathf.Clamp(cameraPosition.x, minPos.x, maxPos.x);
        cameraPosition.y = Mathf.Clamp(cameraPosition.y, minPos.y, maxPos.y);


        if (playerPos.position.x >=  95f && playerPos.position.y >= 6f)
        {
            //cameraPosition.y = f;
            cameraPosition.y = Mathf.Max(cameraPosition.y, playerPos.position.y);
            transform.position = cameraPosition;
        }
        else
        {
            cameraPosition.y = 1.5f;
            transform.position = cameraPosition;
        }

        if(playerPos.position.y >= 6.590025f)
        {
            cameraPosition.y = 7.948418f;
            transform.position = cameraPosition;
        }

        if (playerPos.position.y <= -3.6f && playerPos.position.x > 57f && playerPos.position.x < 60f)
        {
            cameraPosition.y = -5.1f;
            transform.position = cameraPosition;
        }

        if (playerPos.position.x > 27f && playerPos.position.x < 42f)
        {
            cameraPosition.y = 3.41f;
            transform.position = cameraPosition;
        }
    }
}
