using Unity.VisualScripting;
using UnityEngine;

public class EnemyDGMove : MonoBehaviour
{

    public RaycastHit2D GroundCheck;
    public RaycastHit2D FrontCheck;
    public int EnemyFaceLeft;
    public LayerMask Bounces;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        EnemyFaceLeft = 1;

    }

    // Update is called once per frame
    void Update()
    {

        GroundCheck = Physics2D.Raycast(transform.position + new Vector3(-EnemyFaceLeft*1,-1,0), new Vector2(-EnemyFaceLeft, 0), 0.05f);
        FrontCheck = Physics2D.Raycast(transform.position + new Vector3(-EnemyFaceLeft * 0.95f, 0, 0), new Vector2(-EnemyFaceLeft, 0), 0.05f, Bounces);

        if (GroundCheck.collider == null || GroundCheck.collider.gameObject.layer != 6)
        {

            EnemyFaceLeft *= -1;

        }
        else if (FrontCheck.collider != null)
        {

            EnemyFaceLeft *= -1;

        }

        transform.position += new Vector3(-EnemyFaceLeft*2,0,0)*Time.deltaTime;

    }

    void OnTriggerStay2D(Collider2D collider)
    {

        if (collider.gameObject.layer == 3)
        {

            StatManager PlayerHealth = collider.gameObject.GetComponent<StatManager>();
            PlayerHealth.HurtPlayer(1);

        }

    }
}
