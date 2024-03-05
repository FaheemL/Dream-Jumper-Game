using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D Body;
    public Animator anim;
    public PlayerStats Player;
    public Vector2 start;


    
    // Start is called before the first frame update
    void Start()
    {
        Body = GetComponent<Rigidbody2D>();
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (FacingRight())
        {
            //move right
            Body.velocity = new Vector2(moveSpeed, 0f);


        }
        else 
        {
            //move left
            Body.velocity = new Vector2(-moveSpeed, 0f);
        }
    }

    private bool FacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    public void EditState(int state)
    {
        anim.SetInteger("state", (int) state);
        transform.position = start;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Sign") 
        {
            transform.localScale = new Vector2(-(transform.localScale.x), transform.localScale.y);
        }
        if (collision.tag == "Player")
        {
            Player.TakeDamage(15);
        }

        if (collision.tag == "Bullet")
        {
            transform.position = new Vector3(1000000,100000,10);
        }
    
    }
}