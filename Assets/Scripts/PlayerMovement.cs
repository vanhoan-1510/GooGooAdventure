using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private CapsuleCollider2D capsuleCollider;
    public static PlayerMovement Instance;

    private float dirX = 0f;
    private float moveSpeed = 5.5f;
    private float jumpForce = 20f;

    private int count = 1;



    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] GameObject gameOver, gameWiner;
    //enumeration type (or enum type) is a value type defined by a set of named constants of the underlying integral numeric type
    private enum MovementState { idle, running, jumping, dead }

    private void Awake()
    {

        capsuleCollider = GetComponent<CapsuleCollider2D>();

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        if(!Instance)
        {
            Instance = this;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("BouncinessMap"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 21f);
        }

        if (collision.gameObject.CompareTag("Trap")){
            Die();
        }

        if (collision.gameObject.CompareTag("RealCat"))
        {
            Win();
        }
    }

    // Update is called once per frame
    public void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce);
            AudioManager.Instance.PlaySFX("Jump");

        }
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        MovementState state;
        if (dirX > 0)
        {
            state = MovementState.running;
            spriteRenderer.flipX = false;
        }
        else if (dirX < 0)
        {
            state = MovementState.running;
            spriteRenderer.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        //else if (rb.velocity.y < -.1f)
        //{
        //    state = MovementState.dead;
        //}

        animator.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(capsuleCollider.bounds.center, capsuleCollider.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

    public void Die()
    {
        animator.SetTrigger("death");
        moveSpeed= 0f;
        gameOver.SetActive(true);
        if(count== 1)
        {
            GameManager.Instance.Point -= 100;
            AudioManager.Instance.PlaySFX("GameOver");
            count--;
        }
        GameUI.Instance.SetTextPoint();
    }

    public void Win()
    {
        gameWiner.SetActive(true);
        AudioManager.Instance.PlaySFX("GameWinner");
        if (count == 1)
        {
            GameManager.Instance.Point += 1000;
            count--;
        }
        moveSpeed = 0f;
        GameUI.Instance.SetTextPoint();
    }
}
