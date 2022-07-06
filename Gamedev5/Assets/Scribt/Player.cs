using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 5;
    public float jump;
    public Animator animator;
    public bool CanJump = false;
    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        jump = 8;
         rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "Level")
        {
            CanJump = true;
            animator.SetBool("jump", false);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 temp = rb.velocity;

        if (Input.GetAxis("Horizontal") > 0)
            sprite.flipX = false;
        else if (Input.GetAxis("Horizontal") < 0)
            sprite.flipX = true;



        if(CanJump && Input.GetKeyDown(KeyCode.Space))
        {
            temp.y = jump;
            CanJump = false;
            animator.SetBool("jump",true);
        }

        temp.x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = temp;


        //rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0f);

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy" )
        {
            Destroy(collision.gameObject);
        }
    }

   
}
