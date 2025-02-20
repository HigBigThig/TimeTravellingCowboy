using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorpionMovement : MonoBehaviour
{

    public float Range;
    public bool MovingLeft;
    private SpriteRenderer Sprite;

    // Start is called before the first frame update
    void Start()
    {

        Sprite = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (MovingLeft)
        {

            transform.position -= new Vector3(2, 0, 0) * Time.deltaTime;
            if (transform.localPosition.x < -Range)
            {

                MovingLeft = false;

            }

            Sprite.flipX = false;

        }
        else
        {

            transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
            if (transform.localPosition.x > Range)
            {

                MovingLeft = true;

            }

            Sprite.flipX = true;

        }

    }
}
