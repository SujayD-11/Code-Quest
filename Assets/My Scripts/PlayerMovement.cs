using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float dirx;
    private SpriteRenderer sprite;
   [SerializeField] private float moveSpeed = 7f;
   [SerializeField] private float jumpForce = 14f;

    //[SerializeField] private AudioSource JumpSfx;


   

   private enum MovementState {idle, running, jumping,falling }

   private bool isJumping = false;
   

    // Start is called before the first frame update
    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>();
       sprite = GetComponent<SpriteRenderer>();
    //    coll = GetComponent<BoxCollider2D>();

       
    }

    // Update is called once per frame
    private void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(dirx * moveSpeed,rb.velocity.y);

        UpdateAnimation();
    } 

    private void UpdateAnimation(){

        MovementState state;

        if(Input.GetKeyDown("space") && !isJumping)
        {
            //JumpSfx.Play();
            rb.velocity = new Vector2(rb.velocity.x,jumpForce);
            isJumping = true;
         

        }

     

        if(dirx > 0f){

            state = MovementState.running;
            sprite.flipX = false;
        }
        else if(dirx < 0f){
            state = MovementState.running;
            sprite.flipX = true;
        }
        else{
            state = MovementState.idle;
        }

        if(rb.velocity.y > .1f){
            state = MovementState.jumping;
        }

        else if(rb.velocity.y < -.1f){
            state = MovementState.falling;
        }
        
        anim.SetInteger("state",(int)state);
    }

    // private bool isGrounded(){

    // }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")){
            isJumping = false;
        }
    }
}
