using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Blackboxed movement for testing
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 start;
    private Animator anim;
    private SpriteRenderer sprite;
    public PlayerStats player;
    public AudioSource jumpSound;
    public int running;


    private int jumpcount = 0;
    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 25f;

    private enum MovementState { idle, running, jumping, falling }
    

    private void Start()
    {
        start = transform.position;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }


    public void editJumpCount(int x)
    {
        if (jumpcount > x) jumpcount = x;
    }

    private void Update() {
        MovementState state;

        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") & jumpcount < 2) {
            jumpSound.Play();
            jumpcount++;
            Debug.Log(jumpcount);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            if (jumpcount > 1 & player.real) 
            {
                player.TakeEnergy(5);
            }
            
        }

        if (dirX > 0f) {
            state = MovementState.running;
            sprite.flipX = false;
  

        }
        else if (dirX < 0f) {
            state = MovementState.running;
            sprite.flipX = true;
 

        }
        else {
            state = MovementState.idle;

        }

        if (rb.velocity.y > .1f) {
            state = MovementState.jumping;
  
        }
        else if (rb.velocity.y < -.1f) {
            state = MovementState.falling;
     

        }

        anim.SetInteger("state", (int) state);
        
   

       // Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        //moveVelocity = moveInput * speed;
    }

  //  void FixedUpdate(){

   //     rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

  //  }

    public void Respawn()
    {
        transform.position = start;
    }
}
