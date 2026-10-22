using UnityEngine;

public class BulletBehavior : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(BulletLeft*20, 0, 0)*Time.deltaTime;
    }
}
