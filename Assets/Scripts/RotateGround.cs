using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGround : MonoBehaviour
{
    PlayerMovement player;
    GameObject leftGround, rightGround;
    Vector3 rotateAngle;

    private int count = 1;

    private void Start()
    {
        player = GameManager.Instance.player;
        leftGround = GameObject.FindGameObjectWithTag("LeftRotateGround");
        rightGround = GameObject.FindGameObjectWithTag("RightRotateGround");

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(SetGroundRotation(0f));
    }

    private IEnumerator SetGroundRotation(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (count == 1 && player.transform.position.y > 2f)
        {
            leftGround.transform.Rotate(0f, 0f, -90f, Space.Self);
            rightGround.transform.Rotate(0f, 0f,90f, Space.Self);
            count--;
        }
    }

    //private void detectToRotate()
    //{
    //    if (player.transform.position.x >= 73.5 && player.transform.position.y <= 3)
    //    //if (Input.GetKeyDown("z"))
    //    {
    //        gameObject.transform.Rotate(0f, 0f, -90f, Space.Self);
    //    }
    //}
}
