using UnityEngine;

public class EnemyJFMove : MonoBehaviour
{

    private BoxCollider2D SelfCollider;
    private GameObject Player;
    public bool Colliding;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {


        Debug.Log(Player.transform.position.y);
        if(Player.transform.position.y > (transform.position.y + 1.2f))
        {

            SelfCollider.isTrigger = false;

        }
        else
        {

            SelfCollider.isTrigger = true;

        }
        
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
