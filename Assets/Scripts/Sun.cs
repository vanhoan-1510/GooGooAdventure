using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] GameObject questionBlock;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //questionBlock = GameObject.FindGameObjectWithTag("QuestionBlog");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb.gravityScale = 30f;  
        questionBlock.SetActive(true);
        //Debug.Log("Hello");
    }

    //private void Update()
    //{
    //    if (player.transform.position.x >= 23f)
    //    {
    //        rb.gravityScale = 30f;

    //    }
    //}
}
