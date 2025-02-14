using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJAttack : MonoBehaviour
{

    private CJBasicMovement PlayerMovement;
    public LayerMask Enemies;
    private EnemyValues EnemyHealth;
    public GameObject Attack;

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

               Attack = Instantiate(Attack);
               Transform AttackTransform = Attack.transform;
               AttackTransform.position = new Vector3(transform.position.x - 1.5f, transform.position.y, 0);
               AttackTransform.localScale = new Vector3(2, 1, 1);


                RaycastHit2D hit = Physics2D.Raycast(transform.position, (Vector2.left), 2.5f, Enemies);
                if (hit)
                {

                    EnemyHealth = hit.transform.gameObject.GetComponent<EnemyValues>();
                    EnemyHealth.TakeDamage();

                }

            }
            else
            {

                Attack = Instantiate(Attack);
                Transform AttackTransform = Attack.transform;
                AttackTransform.position = new Vector3(transform.position.x + 1.5f, transform.position.y, 0);
                AttackTransform.localScale = new Vector3(2, 1, 1);

                RaycastHit2D hit = Physics2D.Raycast(transform.position, (Vector2.right), 2.5f, Enemies);
                if (hit)
                {

                    EnemyHealth = hit.transform.gameObject.GetComponent<EnemyValues>();
                    EnemyHealth.TakeDamage();

                }

            }

        }
        
    }

}
