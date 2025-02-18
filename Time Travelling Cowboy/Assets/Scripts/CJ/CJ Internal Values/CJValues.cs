using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJValues : MonoBehaviour
{

    public int Health;
    public int Ammo;
    private int type;
    private CJDeath Death;

    // Start is called before the first frame update
    void Start()
    {

        Death = gameObject.GetComponent<CJDeath>();

    }

    // Update is called once per frame
    void Update()
    {
        type = Random.Range(0, 100);
        if (type == 69)
        {

            Debug.Log(Health);
        }
    }

    public void TakeDamage()
    {

        Health -= 1;

        if (Health <= 0)
        {

            Death.Death();

        }

    }

}
