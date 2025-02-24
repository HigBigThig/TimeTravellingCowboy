using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableWallDestruction : MonoBehaviour
{

    private CJAttack PlayerShoot;
    [SerializeField] GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

        PlayerShoot = Player.GetComponent<CJAttack>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {

        PlayerShoot.PastShootTutorial = true;
        Destroy(transform.parent.gameObject);

    }

}
