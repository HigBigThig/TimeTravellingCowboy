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

        GroundCheck = Physics2D.Raycast(transform.position + new Vector3(-EnemyFaceLeft*1,-1,0), new Vector2(-EnemyFaceLeft, 0), 0.2f);
        FrontCheck = Physics2D.Raycast(transform.position + new Vector3(-EnemyFaceLeft * 1, 0, 0), new Vector2(-EnemyFaceLeft, 0), 0.2f);

        if (GroundCheck.collider == null || GroundCheck.collider.gameObject.layer != 6)
        {

            EnemyFaceLeft *= -1;

        }
        else if (FrontCheck.collider != null)
        {

            if (FrontCheck.collider.gameObject != gameObject && FrontCheck.collider.gameObject.layer == Bounces)
            {

                EnemyFaceLeft *= -1;

            }

        }

    }
}
