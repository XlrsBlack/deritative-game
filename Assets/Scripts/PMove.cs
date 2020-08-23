using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Animator anim;
    public float speed = 10f;
    public float jumpForce;
    public bool salto;

    void OnCollisionStay2D(Collision2D collision)
    {
        salto = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        salto = false;   
    }
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update  ()
    {
        
    }
    void FixedUpdate()
    {
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Grounded", salto);
        float h = Input.GetAxis("Horizontal");
        rb2d.AddForce(Vector2.right * speed * h);
        if (Input.GetKey(KeyCode.DownArrow) && jumpForce > -5.2 )
        {
            rb2d.AddForce(new Vector2(0, jumpForce--), ForceMode2D.Impulse);
        }
        if ( Input.GetKeyUp(KeyCode.DownArrow))
        {
            jumpForce = 0;
        }
        if (Input.GetKey(KeyCode.X) && speed < 28)
        {
            speed++;
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            speed = 8;
        }
    }   
}

