using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJBasicMovement : MonoBehaviour
{

    public Rigidbody2D rb;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(Vector2.up * 500);

        }

    }
}
