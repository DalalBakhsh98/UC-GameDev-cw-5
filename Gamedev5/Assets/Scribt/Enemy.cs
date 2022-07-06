using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool direction;
    public Rigidbody2D rb;
    public float speed;
    public Transform rightT;
    private bool Turn;

    public LayerMask groundLayer;
    

    // Start is called before the first frame update
    void Start()
    {
        direction = true;
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(direction)
        {
            patrol();

        }
        
    }

    private void FixedUpdate()
    {
        if(direction)
        {
            Turn = !Physics2D.OverlapCircle(rightT.position, 0.1f, groundLayer);
        }
    }

    void patrol()
    {
        if(Turn)
        {
            flip();
        }
        rb.velocity = new Vector2(speed *Time.fixedDeltaTime, rb.velocity.y);
    }

    void flip()
    {

        direction = false;
        transform.localScale = new Vector2 (transform.localScale.x * -1 , transform.localScale.y);
        speed *= -1;
        direction = true;
    }


}
