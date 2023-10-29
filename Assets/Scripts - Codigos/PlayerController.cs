using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;


    [Header("Movimiento")]
    public float moveSpeed;

    [Header("Salto")]
    public float jumpForce;

    [Header("Componentes")]
    public Rigidbody2D theRB;

    [Header("Animator")]
    public Animator anim;
    private SpriteRenderer TheSR;

    [Header("Grounded")]
    private bool isGrounded;
    public Transform groundCheckpoint;
    public LayerMask whatIsGround;


    public float knockBackLength, knockBackForce;
    private float knockBackCounter;

    private void Awake() 
    {
        instance = this;
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        TheSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if(knockBackCounter <= 0)
        {
                theRB.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), theRB.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheckpoint.position, .2f, whatIsGround);

        if(Input.GetButtonDown("Jump"))
        {
            if(isGrounded)
            {
                theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
            }
            
        }

        if(theRB.velocity.x < 0)
        {
            TheSR.flipX = true;
        } else if(theRB.velocity.x > 0)
        {
            TheSR.flipX = false;
         }
      }else
      {
        knockBackCounter -= Time.deltaTime;
        if(TheSR.flipX)
        {
            theRB.velocity = new Vector2(-knockBackForce, theRB.velocity.y);
        }else
        {
            theRB.velocity = new Vector2(knockBackForce, theRB.velocity.y);
        }
      }


        

        anim.SetFloat("moveSpeed", Mathf.Abs(theRB.velocity.x));
        anim.SetBool("isGrounded", isGrounded);
    }

    public void knockBack()
    {
        knockBackCounter = knockBackLength;
        theRB.velocity = new Vector2(0f, knockBackForce);
    }
}
