using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJBasicMovement : MonoBehaviour
{


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


        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.1f, LayerMask.GetMask("Environment"));
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Velocity.y = 10;

        }
        else if (hit.collider == null)
        {

            Velocity.y -= 10 * Time.deltaTime;

        }
        else
        {

            Velocity.y = 0;
        
        } 

      

        transform.position = transform.position + Velocity * Time.deltaTime;

    }
}
