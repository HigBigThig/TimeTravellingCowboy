using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorpionMovement : MonoBehaviour
{

    public float Range;
    public bool MovingLeft;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
        if (MovingLeft)
        {

            transform.position -= new Vector3(2, 0, 0) * Time.deltaTime;
            if (transform.position.x < -Range)
            {

                MovingLeft = false;

            }

        }
        else
        {

            transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
            if (transform.position.x > Range)
            {

                MovingLeft = true;

            }

        }

    }
}
