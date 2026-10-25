using UnityEngine;

public class StatManager : MonoBehaviour
{

    public int PlayerHealth;
    public int PlayerHealthFull;
    public int MaskShards;
    public bool GunUpgrade;
    public bool KnifeUpgrade;
    public int Ammo;
    public bool ShopKey;
    public int Geo;
    public bool TimeTravel;
    public bool Dash;
    public bool DoubleJump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        PlayerHealth = 5;
        PlayerHealthFull = 5;
        MaskShards = 0;
        GunUpgrade = false;
        KnifeUpgrade = false;
        Ammo = 20;
        ShopKey = false;
        Geo = 0;
        TimeTravel = false;
        Dash = false;
        DoubleJump = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HurtPlayer(int Damage)
    {

        PlayerHealth -= Damage;
        if (PlayerHealth < 0)
        {

            Death();

        }

    }

    void Death()
    {

        Debug.Log("DEAD");

    }
}
