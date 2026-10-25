 using UnityEngine;

public class BulletBehavior : MonoBehaviour
{

    public int BulletLeft;
    public float BulletLife;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        BulletLife -= Time.deltaTime;
        transform.position += new Vector3(-BulletLeft*20, 0, 0)*Time.deltaTime;
        if (BulletLife < 0)
        {

            Destroy(gameObject);

        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("hit");

        if(collision.gameObject.layer != 3)
        {

            if (collision.gameObject.layer == 7)
            {

                EnemyGetHurt CurrentEnemy = collision.gameObject.GetComponent<EnemyGetHurt>();

                CurrentEnemy.TakeDamage(6);

            }

            Destroy(gameObject);

        }

    }

}
