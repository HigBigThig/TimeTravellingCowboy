using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJBasicMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public int JumpsLeft;
    public bool Grounded = false;
    public LayerMask Ground;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y < -15)
        {

            rb.gravityScale = 0;

        }
        else
        {

            rb.gravityScale = 2;

        }

        if (Input.GetKey(KeyCode.A))
        {

            rb.velocity = new Vector2(-5, rb.velocity.y);

        }
        else if (Input.GetKey(KeyCode.D))
        {

            rb.velocity = new Vector2(5, rb.velocity.y);

        }
        else
        {

            rb.velocity = new Vector2(0, rb.velocity.y);

        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.75f, Ground);

        if (hit) 
        {

            Grounded = true;
            JumpsLeft = 1;

        }
        else
        {

            Grounded = false;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Grounded)
            {

                rb.AddForce(Vector2.up * 500);

            }
            else if (JumpsLeft > 0)
            {

                rb.velocity = new Vector2(rb.velocity.x, 10);
                JumpsLeft -= 1;

            }
        }


    }
}
