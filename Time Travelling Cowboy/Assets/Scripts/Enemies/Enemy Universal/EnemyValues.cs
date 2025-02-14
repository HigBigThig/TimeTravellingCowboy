using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyValues : MonoBehaviour
{

    public int Health;
    private EnemyDeath Death;

    // Start is called before the first frame update
    void Start()
    {

        Death = gameObject.GetComponent<EnemyDeath>();

    }

    // Update is called once per frame
    void Update()
    {
        
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
