using UnityEngine;
using UnityEngine.InputSystem;

public class CJMoveMain : MonoBehaviour
{

    public InputActionReference ADMove;
    public InputActionReference SpaceMove;

    public LayerMask FloorsLayer;

    public float XVelocity;
    public float YVelocity;
    public int PlayerSpeed = 10;
    private RaycastHit2D Grounder;
    private float DashTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        DashTime = 0;

    }

    // Update is called once per frame
    void Update()
    {

        DashTime -= Time.deltaTime;

        Grounder = Physics2D.BoxCast((transform.position)+new Vector3 (0,-0.1f), transform.localScale, 0f, Vector3.down, 0, FloorsLayer);



        if (DashTime < 0)
        {

            XVelocity = (ADMove.action.ReadValue<float>()) * PlayerSpeed;

        }
        Debug.Log(Grounder.collider);

        if (SpaceMove.action.ReadValue<float>() > 0.5f)
        {

            YVelocity = 15;

        }
        else if(Grounder.collider == null)
        {

            YVelocity -= 85 * Time.deltaTime;

        }
        else
        {

            YVelocity = 0;

        }

        transform.position += new Vector3(XVelocity, YVelocity, 0) * Time.deltaTime;

    }
}
