using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class CJMoveMain : MonoBehaviour
{

    public InputActionReference ADMove;
    public InputActionReference SpaceMove;
    public InputActionReference DashMove;

    public LayerMask FloorsLayer;

    public float XVelocity;
    public float YVelocity;
    public int PlayerSpeed = 10;
    private RaycastHit2D Grounder;
    private RaycastHit2D LRWaller;
    private RaycastHit2D Roofer;
    private RaycastHit2D Dasher;
    private float DashTime;
    private int FaceLeft;
    private float DashCooldown;
    private float JumpTime;
    private bool Jumping;
    private bool DoubleJump;
    private bool WasJump;
    private float RoofTime;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        DashTime = 0;
        RoofTime = 0; 
        DashCooldown = 0;

    }

    // Update is called once per frame
    void Update()
    {

        RoofTime -= Time.deltaTime;

        JumpTime -= Time.deltaTime;

        DashTime -= Time.deltaTime;

        DashCooldown -= Time.deltaTime;

        Grounder = Physics2D.BoxCast((transform.position) + new Vector3 (0,-0.1f), transform.localScale, 0f, Vector3.down, 0, FloorsLayer);
        Roofer = Physics2D.BoxCast((transform.position) + new Vector3(0, 0.1f), transform.localScale, 0f, Vector3.down, 0, FloorsLayer);
        LRWaller = Physics2D.BoxCast((transform.position) + new Vector3((0.1f*((ADMove.action.ReadValue<float>()))), 0), transform.localScale - new Vector3(0, 0.1f), 0f, Vector3.down, 0, FloorsLayer);


        if (JumpTime<0)
        {

            Jumping = false;
            JumpTime = 0;

        }

        if (DashMove.action.ReadValue<float>()>0.5f)
        {

            Dasher = Physics2D.BoxCast((transform.position), 0.95f * transform.localScale, 0, new Vector3(FaceLeft, 0), 5, FloorsLayer);
            if (Dasher.collider != null && (DashCooldown < 0))
            {

                XVelocity = -25 * FaceLeft;
                DashTime = 0.04f * ((Dasher.distance)-0.5f);
                DashCooldown = 1;
            
            }
        
        }
        if (DashTime < 0)
        {

            if (LRWaller.collider == null)
            {

                XVelocity = (ADMove.action.ReadValue<float>()) * PlayerSpeed;
                if (XVelocity < 0)
                {

                    FaceLeft = 1;

                }
                else if (XVelocity > 0)
                {

                    FaceLeft = -1;

                }
            }
            else 
            {

                XVelocity = 0;

            }

        }
        Debug.Log(Grounder.collider);


        if (Roofer.collider != null && RoofTime < 0)
        {

            YVelocity = 0;
            RoofTime = 0.2f;

        }
        else if (DashTime > 0) 
        {

            YVelocity = 0;
        
        }
        else if (((SpaceMove.action.ReadValue<float>() > 0.5f) && Grounder.collider != null))
        {

            YVelocity = 15;
            JumpTime = 0.7f;
            Jumping = true;
            WasJump = true;
            DoubleJump = true;

        }
        else if (((SpaceMove.action.ReadValue<float>() > 0.5f) && (WasJump == false) && (DoubleJump == true)))
        {

            YVelocity = 13;
            JumpTime = 0.55f;
            Jumping = true;
            DoubleJump = false;

        }
        else if ((SpaceMove.action.ReadValue<float>() > 0.5f) && Jumping)
        {

            YVelocity -= ((105 - (92f * math.sqrt(JumpTime))) * Time.deltaTime);

        }
        else if (Grounder.collider == null)
        {

            YVelocity -= 105 * Time.deltaTime;
            WasJump = false;

        }
        else
        {

            YVelocity = 0;
            WasJump = false;
            DoubleJump = true;

        }

        transform.position += new Vector3(XVelocity, YVelocity, 0) * Time.deltaTime;

    }
}
