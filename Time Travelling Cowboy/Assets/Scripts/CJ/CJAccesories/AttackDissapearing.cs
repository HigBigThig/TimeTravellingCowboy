using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDissapearing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AttackDisappear1()
    {

        Invoke(nameof(AttackDisappear), 0.5f);

    }

    private void AttackDisappear()
    {

        Destroy(gameObject);

    }

}
