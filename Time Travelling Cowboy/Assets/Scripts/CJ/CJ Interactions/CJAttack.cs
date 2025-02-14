using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJAttack : MonoBehaviour
{

    private CJBasicMovement PlayerMovement;
    public LayerMask Enemies;
    private EnemyValues EnemyHealth;

    // Start is called before the first frame update
    void Start()
    {

        PlayerMovement = gameObject.GetComponent<CJBasicMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (PlayerMovement.CJFacingLeft)
            {

                RaycastHit2D hit = Physics2D.Raycast(transform.position, (Vector2.left), 6, Enemies);
                if (hit)
                {

                    EnemyHealth = hit.transform.gameObject.GetComponent<EnemyValues>();
                    EnemyHealth.TakeDamage();

                }

            }
            else
            {

                RaycastHit2D hit = Physics2D.Raycast(transform.position, (Vector2.right), 6, Enemies);
                if (hit)
                {

                    EnemyHealth = hit.transform.gameObject.GetComponent<EnemyValues>();
                    EnemyHealth.TakeDamage();

                }

            }

        }
        
    }

}
