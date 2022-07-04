using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 10;
    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        jump = 5;
         rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 temp = rb.velocity;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            temp.y = jump;
        }

        temp.x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = temp;


        //rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0f);

        
    }
}
