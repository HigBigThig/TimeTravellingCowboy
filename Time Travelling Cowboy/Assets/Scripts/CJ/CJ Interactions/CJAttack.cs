using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJAttack : MonoBehaviour
{

    private CJBasicMovement PlayerMovement;
    private CJValues AmmoCount;
    public LayerMask Enemies;
    private EnemyValues EnemyHealth;
    public GameObject Attack;
    private GameObject AttackReal;
    [SerializeField] private GameObject Bullet;
    private AttackDissapearing AttackDisappearing;
    private bool CanAttack;
    private bool CanShoot;
    private BreakableWallDestruction BreakableWallHealth;
    [SerializeField] LayerMask BreakableWall;

    // Start is called before the first frame update
    void Start()
    {

        PlayerMovement = gameObject.GetComponent<CJBasicMovement>();
        AmmoCount = gameObject.GetComponent<CJValues>();
        CanAttack = true;
        CanShoot = true;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.J) && CanAttack == true)
        {

            if (PlayerMovement.CJFacingLeft)
            {

                CanAttack = false;
                Invoke(nameof(CanAttackMethod), 0.5f);

                AttackReal = Instantiate(Attack);
                Transform AttackTransform = AttackReal.transform;
                AttackTransform.position = new Vector3(transform.position.x - 1.5f, transform.position.y, 0);
                AttackTransform.localScale = new Vector3(2, 1, 1); 
                AttackDisappearing = AttackReal.GetComponent<AttackDissapearing>();
                AttackDisappearing.AttackDisappear1();

                RaycastHit2D hit = Physics2D.Raycast(transform.position, (Vector2.left), 2.5f, Enemies);
                if (hit)
                {
                
                    EnemyHealth = hit.transform.gameObject.GetComponent<EnemyValues>();
                    EnemyHealth.TakeDamage();

                }
                else
                {

                    RaycastHit2D wallhit = Physics2D.Raycast(transform.position, (Vector2.left), 2.5f, BreakableWall);
                    if (wallhit)
                    {

                        BreakableWallHealth = wallhit.transform.gameObject.GetComponent<BreakableWallDestruction>();
                        BreakableWallHealth.TakeDamage();

                    }

                }

            }
            else
            {

                CanAttack = false;
                Invoke(nameof(CanAttackMethod), 0.5f);

                AttackReal = Instantiate(Attack);
                Transform AttackTransform = AttackReal.transform;
                AttackTransform.position = new Vector3(transform.position.x + 1.5f, transform.position.y, 0);
                AttackTransform.localScale = new Vector3(2, 1, 1);
                AttackDisappearing = AttackReal.GetComponent<AttackDissapearing>();
                AttackDisappearing.AttackDisappear1();

                RaycastHit2D hit = Physics2D.Raycast(transform.position, (Vector2.right), 2.5f, Enemies);
                if (hit)
                {

                    EnemyHealth = hit.transform.gameObject.GetComponent<EnemyValues>();
                    EnemyHealth.TakeDamage();

                }
                else
                {

                    RaycastHit2D wallhit = Physics2D.Raycast(transform.position, (Vector2.right), 2.5f, BreakableWall);
                    if (wallhit)
                    {

                        BreakableWallHealth = wallhit.transform.gameObject.GetComponent<BreakableWallDestruction>();
                        BreakableWallHealth.TakeDamage();

                    }

                }

            }

        }

        if (Input.GetKeyDown(KeyCode.I) && CanShoot)
        {

            Invoke(nameof(CanShootMethod), 0.3f);
            CanShoot = false;

            if (AmmoCount.Ammo > 0)
            {

                Instantiate(Bullet, gameObject.transform);
                AmmoCount.Ammo -= 1;

            }

        }
        
    }

    private void CanAttackMethod()
    {

        CanAttack = true;

    }

    private void CanShootMethod()
    {

        CanShoot = true;

    }

}
