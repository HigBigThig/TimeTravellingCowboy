using Unity.Mathematics;
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
    private RaycastHit2D LRWaller;
    private RaycastHit2D Roofer;
    private float DashTime;
    private float JumpTime;
    private bool Jumping;
    private float RoofTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        DashTime = 0;
        RoofTime = 0; 

    }

    // Update is called once per frame
    void Update()
    {

        RoofTime -= Time.deltaTime;

        JumpTime -= Time.deltaTime;

        DashTime -= Time.deltaTime;

        Grounder = Physics2D.BoxCast((transform.position) + new Vector3 (0,-0.1f), transform.localScale, 0f, Vector3.down, 0, FloorsLayer);
        Roofer = Physics2D.BoxCast((transform.position) + new Vector3(0, 0.1f), transform.localScale, 0f, Vector3.down, 0, FloorsLayer);
        LRWaller = Physics2D.BoxCast((transform.position) + new Vector3((0.1f*((ADMove.action.ReadValue<float>()))), 0), transform.localScale - new Vector3(0, 0.1f), 0f, Vector3.down, 0, FloorsLayer);

        if (JumpTime<0)
        {

            Jumping = false;
            JumpTime = 0;

        }

        if (DashTime < 0)
        {

            if (LRWaller.collider == null)
            {

                XVelocity = (ADMove.action.ReadValue<float>()) * PlayerSpeed;

            }
            else 
            {

                XVelocity = 0;

            }

        }
        Debug.Log(Grounder.collider);

        if (Roofer.collider != null && RoofTime<0)
        {

            YVelocity = 0;
            RoofTime = 0.2f;

        }
        else if ((SpaceMove.action.ReadValue<float>() > 0.5f) && Grounder.collider!=null)
        {

            YVelocity = 15;
            JumpTime = 0.7f;
            Jumping = true;

        }
        else if ((SpaceMove.action.ReadValue<float>() > 0.5f) && Jumping)
        {

            YVelocity -= ((105 - (92f * math.sqrt(JumpTime))) * Time.deltaTime);

        }
        else if(Grounder.collider == null)
        {

            YVelocity -= 105 * Time.deltaTime;

        }
        else
        {

            YVelocity = 0;

        }

        transform.position += new Vector3(XVelocity, YVelocity, 0) * Time.deltaTime;

    }
}
