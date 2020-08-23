using UnityEngine;
using System.Collections;
using System.Collections.Generic;

     public class Saltito : MonoBehaviour
{
     
         private Vector2 jump;
         public float jumpForce = 2.0f;
         public bool bruh;
         public bool isGrounded;
         Rigidbody2D rb;
         void Start(){
             rb = GetComponent<Rigidbody2D>();
             jump = new Vector2(0, 2.0f);
         }
    void OnCollisionStay2D (Collision2D collision)
    {
        isGrounded = true;
        bruh = false;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        bruh = true;   
    }

    void Update()
       {
         if(Input.GetKey(KeyCode.Space)&& jumpForce<6.2)
        {
            jumpForce++;
            jumpForce = jumpForce*2;
        }
        if (Input.GetKeyUp(KeyCode.Space) && isGrounded)
        {
     
                 rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
                 isGrounded = false;
        }
        if (bruh)
        {
            jumpForce = 0;
        }
       }
     }