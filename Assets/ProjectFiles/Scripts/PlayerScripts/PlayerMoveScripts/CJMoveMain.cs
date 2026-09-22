using UnityEngine;
using UnityEngine.InputSystem;

public class CJMoveMain : MonoBehaviour
{

    public InputActionReference ADMove;

    public float XVelocity;
    public float YVelocity;
    public int PlayerSpeed = 10;
    private RaycastHit2D Grounder;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        Grounder = Physics2D.BoxCast((transform.position)-new Vector3 (0,-0.1f), transform.localScale, 0f, Vector3.down);

        XVelocity = (ADMove.action.ReadValue<float>())*PlayerSpeed;


        if(Grounder.collider != null)
        {

            YVelocity -= 10 * Time.deltaTime;

        }
        else
        {

            YVelocity = 0;

        }

        transform.position += new Vector3(XVelocity, YVelocity, 0) * Time.deltaTime;

    }
}
