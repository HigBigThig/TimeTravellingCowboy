using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJValues : MonoBehaviour
{

    public int Health;
    public int Ammo;
    private CJDeath Death;
    [SerializeField] GameObject Heart1;
    [SerializeField] GameObject Heart2;
    [SerializeField] GameObject Heart3;
    [SerializeField] GameObject Heart4;
    [SerializeField] GameObject Heart5;
    private HealthDisplay Display1;
    private HealthDisplay Display2;
    private HealthDisplay Display3;
    private HealthDisplay Display4;
    private HealthDisplay Display5;
    public bool Immunity;

    // Start is called before the first frame update
    void Start()
    {

        Death = gameObject.GetComponent<CJDeath>();
        Display1 = Heart1.GetComponent<HealthDisplay>();
        Display2 = Heart2.GetComponent<HealthDisplay>();
        Display3 = Heart3.GetComponent<HealthDisplay>();
        Display4 = Heart4.GetComponent<HealthDisplay>();
        Display5 = Heart5.GetComponent<HealthDisplay>();
        Immunity = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage()
    {
        if (!Immunity)
        {

            Invoke(nameof(ImmunityREJECTED), 1);
            Immunity = true;

            Health -= 1;

            if (Health <= 0)
            {

                Death.Death();

            }

            Display1.ShowDamage(Health);
            Display2.ShowDamage(Health);
            Display3.ShowDamage(Health);
            Display4.ShowDamage(Health);
            Display5.ShowDamage(Health);

        }

    }

    private void ImmunityREJECTED()
    {

        Immunity = false;

    }

}
