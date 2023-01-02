using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodLine : MonoBehaviour
{
    public Transform pos1, pos2, pos3;
    private float speed = 1.4f;
    public Transform startPos;

    private Vector3 nextPos;

    private void Start()
    {
        nextPos = startPos.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pos1 = pos3;
        nextPos = pos1.position;
    }
    private void Update()
    {
        if(transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }

        if(transform.position == pos2.position)
        {
            nextPos= pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);


    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }

    //private void LateUpdate()
    //{
    //    if (player.transform.position.y > 2.5f)
    //    {
    //        Vector3 cameraPosition = camera.transform.position;
    //        cameraPosition.y = Mathf.Max(cameraPosition.y, player.transform.position.y);
            
    //    }
    //}
}