using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class CJAttackMain : MonoBehaviour
{

    public InputActionReference MeleeKill;
    public InputActionReference RangeKill;
    private float AttackTime;
    public GameObject BulletPrefab;
    public GameObject SlashPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        AttackTime = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

        AttackTime -= Time.deltaTime;

        if (MeleeKill.action.ReadValue<float>() > 0.5f)
        {

            if(AttackTime < 0)
            {

                Stab();
                AttackTime = 0.335f;

            }

        }

        if (RangeKill.action.ReadValue<float>() > 0.5f)
        {

            if (AttackTime < 0)
            {

                Shoot();
                AttackTime = 0.714f;

            }

        }

    }

    private void Stab()
    {

        Debug.Log("GOTCHA");
        GameObject SlashNOW = Instantiate(SlashPrefab);
        SlashNOW.transform.position = transform.position - new Vector3(1.3f*gameObject.GetComponent<CJMoveMain>().FaceLeft,0,0);


    }

    private void Shoot()
    {

        Debug.Log("POW");
        GameObject BulletNOW = Instantiate(BulletPrefab);
        BulletNOW.transform.position = transform.position;
        BulletBehavior bulletmove = BulletNOW.GetComponent<BulletBehavior>();
        bulletmove.BulletLeft = gameObject.GetComponent<CJMoveMain>().FaceLeft;

    }
}
