using UnityEngine;

public class CameraTracking : MonoBehaviour
{

    public float LeftBound;
    public float RightBound;
    public float UpBound;
    public float DownBound;
    public GameObject PlayerTracker;
    private float NewX;
    private float NewY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        

        //IF YOU HAVE TO READ THROUGH THIS, THEN KNOW THAT IM VERY SORRY
        //ITS BASICALLY just all the cases for the players X position to tell the camera where it should be.
        if(PlayerTracker.transform.position.x < RightBound && PlayerTracker.transform.position.x > LeftBound)
        {

            NewX = PlayerTracker.transform.position.x;
            
        }
        else if((PlayerTracker.transform.position.x - 100) < RightBound && (PlayerTracker.transform.position.x - 100) > LeftBound)
        {

            NewX = PlayerTracker.transform.position.x;

        }
        else if(PlayerTracker.transform.position.x < LeftBound)
        {

            NewX = LeftBound;

        }
        else if(PlayerTracker.transform.position.x > (RightBound + 100))
        {

            NewX = RightBound + 100;

        }
        else if( PlayerTracker.transform.position.x > RightBound && PlayerTracker.transform.position.x < (LeftBound + 100))
        {

            if (PlayerTracker.transform.position.x < 50)
            {

                NewX = RightBound;

            }
            else
            {

                NewX = LeftBound + 100;

            }

        }

        if (PlayerTracker.transform.position.y < UpBound && PlayerTracker.transform.position.y > DownBound)
        {

            NewY = PlayerTracker.transform.position.y - 1;

        }

        transform.position = new Vector3(NewX, NewY, -15);



    }
}
