using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyValues : MonoBehaviour
{

    public int Health;
    private EnemyDeath Death;
    private Color DefaultColor;
    private SpriteRenderer Sprite;


    // Start is called before the first frame update
    void Start()
    {

        Death = gameObject.GetComponent<EnemyDeath>();
        Sprite = gameObject.GetComponent<SpriteRenderer>();
        DefaultColor = Sprite.color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        Invoke(nameof(BackToNormal), 0.15f);
        Sprite.color = Color.red;
        Health -= 1;
        if (Health <= 0)
        {

            Death.Death();

        }

    }

    private void BackToNormal()
    {

        Sprite.color = DefaultColor;

    }

}
