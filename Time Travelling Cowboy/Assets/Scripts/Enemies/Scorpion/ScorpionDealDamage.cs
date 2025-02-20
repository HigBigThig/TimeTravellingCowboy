using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorpionDealDamage : MonoBehaviour
{

    public GameObject Player;
    private CJValues PlayerValues;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.layer == 8f)
        {

            Player = collider.gameObject;
            PlayerValues = Player.GetComponent<CJValues>();
            PlayerValues.TakeDamage();

        }

    }

}
