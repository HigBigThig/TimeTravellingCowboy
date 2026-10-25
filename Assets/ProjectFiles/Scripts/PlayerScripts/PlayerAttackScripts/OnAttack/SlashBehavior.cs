using UnityEngine;

public class SlashBehavior : MonoBehaviour
{

    public float SlashLife;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        SlashLife -= Time.deltaTime;   

        if(SlashLife < 0)
        {

            Destroy(gameObject);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.layer == 7)
        {

            EnemyGetHurt CurrentEnemy = collision.gameObject.GetComponent<EnemyGetHurt>();
            CurrentEnemy.TakeDamage(10);

        }

    }
}
