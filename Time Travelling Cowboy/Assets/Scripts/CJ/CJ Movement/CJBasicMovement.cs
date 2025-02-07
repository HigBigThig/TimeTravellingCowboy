using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJBasicMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector3 Velocity = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {

            Velocity.x = -5;

        }
        else if (Input.GetKey(KeyCode.D))
        {

            Velocity.x = 5;

        }
        else
        {

            Velocity.x = 0;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(Vector2.up * 500);

        }


      

        transform.position += Velocity * Time.deltaTime;

    }
}
