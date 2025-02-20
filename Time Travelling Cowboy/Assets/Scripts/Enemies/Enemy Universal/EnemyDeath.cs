using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    [SerializeField] GameObject AmmoDrop;
    private GameObject AmmoDropReal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Death()
    {

        if (Random.Range(0, 100) > 35)
        {

            AmmoDropReal = Instantiate(AmmoDrop); 
            AmmoDropReal.transform.position = transform.position;
            AmmoDropReal.layer = 10;

        }

        Destroy(gameObject);

    }

}
