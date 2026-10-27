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
    public float IFrames;

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
        IFrames = 0;

    }

    // Update is called once per frame
    void Update()
    {

        IFrames -= Time.deltaTime;
        
    }

    public void HurtPlayer(int Damage)
    {
        if (IFrames < 0)
        {
            PlayerHealth -= Damage;
            Debug.Log("OUCH");
            if (PlayerHealth <= 0)
            {

                Death();

            }

            IFrames = 1;

        }

    }

    void Death()
    {

        Debug.Log("DEAD");

    }

    public void MaskShardCollect()
    {

        Debug.Log("Helth!");

    }

    public void GunUpgradeCollect()
    {

        Debug.Log("BETTERShoots!");

    }

    public void KnifeUpgradeCollect()
    {

        Debug.Log("BetterSTABS!");

    }

}
