using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{

    private CJValues CJAmmo;

    private GameObject CJ;

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

        if (collider.gameObject.layer == 8)
        {

            CJAmmo = collider.gameObject.GetComponent<CJValues>();
            CJAmmo.Ammo += 5;
            Destroy(gameObject);

        }

    }

}
