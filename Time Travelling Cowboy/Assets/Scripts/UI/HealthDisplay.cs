using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{

    [SerializeField] int HeartNumber;
    [SerializeField] Sprite Heart;
    Image Display;

    // Start is called before the first frame update
    void Start()
    {
        
        Display = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDamage(int NewHealth)
    {

        if (NewHealth <= HeartNumber)
        {

            Display.sprite = null;

        }
        else
        {

            Display.sprite = Heart;

        }

    }

}
