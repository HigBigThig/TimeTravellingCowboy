using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{

    [SerializeField] int HeartNumber;
    [SerializeField] Sprite Heart;
    [SerializeField] Color Blank;
    [SerializeField] Color White;
    Image Display;

    // Start is called before the first frame update
    void Start()
    {
        
        Display = GetComponent<Image>();
        Display.sprite = Heart;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDamage(int NewHealth)
    {

        if (NewHealth < HeartNumber)
        {

            Display.sprite = null;
            Display.color = Blank;

        }
        else
        {

            Display.sprite = Heart;
            Display.color = White;

        }

    }

}
