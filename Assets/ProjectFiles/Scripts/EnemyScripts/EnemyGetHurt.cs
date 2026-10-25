using UnityEngine;

public class EnemyGetHurt : MonoBehaviour
{

    public int Health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckDeath()
    {

        if (Health <= 0)
        {

            Destroy(gameObject);

        }

    }

    public void TakeDamage(int Damage)
    {

        Health -= Damage;
        CheckDeath();

    }

}
