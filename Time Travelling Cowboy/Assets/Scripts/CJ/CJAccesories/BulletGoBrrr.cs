using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGoBrrr : MonoBehaviour
{

    private int DirectionModifier;
    private CJBasicMovement CJ;
    private EnemyValues EnemyValues;

    // Start is called before the first frame update
    void Start()
    {

        Invoke(nameof(Despawn), 1f);

        CJ = GetComponentInParent<CJBasicMovement>();

        if (CJ.CJFacingLeft == true)
        {

            DirectionModifier = -1;

        }
        else
        {

            DirectionModifier = 1;

        }

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(15 * Time.deltaTime * DirectionModifier, 0);

    }

    private void Despawn()
    {

        Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
     
        if (collider.gameObject.layer == 7)
        {

            EnemyValues = collider.GetComponent<EnemyValues>();
            EnemyValues.TakeDamage();

        }
        
        Despawn();

    }

}
