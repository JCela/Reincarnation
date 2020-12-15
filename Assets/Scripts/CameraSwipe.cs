using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the input manager and Camera manager, It wouldn't let me name it inputmanager so i named it "Cameraswipe".
public class CameraSwipe : MonoBehaviour
{
    //Transform Declaration
    public Transform camTransf;
    public Transform topofProfile;
    public Transform bottomofProfile;
    public Transform centerofProfile;
    public float camSpeed = 1.0f;

    //Float Declaration
    private float camJourneyUp;
    private float camJourneyDown;
    private float fractionOfcamJourneyUp;
    private float fractionOfcamJourneyDown;
    public GameObject Manager;
    private UIManager uiManagerScript;
    private CharacterManager charScript;
    private ScoreManager score;

    void Start()
    {
        uiManagerScript = Manager.GetComponent<UIManager>();
        charScript = Manager.GetComponent<CharacterManager>();
        score = Manager.GetComponent<ScoreManager>();


        camJourneyUp = Vector3.Distance(camTransf.position, topofProfile.position);
        camJourneyDown = Vector3.Distance(camTransf.position, bottomofProfile.position);

    }
    void Update(){
        //Input variables, and calling checkinput with said variables
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        CheckInput(xAxis,yAxis);

        //Camera movement Variables
        float distanceCovered = Vector3.Distance(camTransf.position, centerofProfile.position);
        fractionOfcamJourneyUp =  (distanceCovered*2) * Time.deltaTime / camJourneyUp;
        fractionOfcamJourneyDown = (distanceCovered*2) * Time.deltaTime / camJourneyDown;
    }

    public void CheckInput(float x, float y)
    {
        if (y == 1)
        {
            //MoveCamUp();
        }
        else if (y == -1)
        {
            //MoveCamDown();
            
        }
        else if (y == 0 && x == 0)
        {
            //ReturnCamMiddle();
            
        }

        if (Input.GetKeyDown("space"))
        {
            ChoseAscend();

        }
        else if (Input.GetKeyDown("delete"))
        {
            ChoseReincarnate();

        }
    }

    void MoveCamUp()
    {
        Debug.Log("Moving Up");
        camTransf.position = Vector3.Lerp(camTransf.position, topofProfile.position, camSpeed);//change camSpeed to fractionOfcamJourneyUp in order to mimick swipe controls.  
    }
    void MoveCamDown()
    {
        Debug.Log("Moving Down");
        camTransf.position = Vector3.Lerp(camTransf.position, bottomofProfile.position, camSpeed);//change camSpeed to fractionOfcamJourneyDown in order to mimick swipe controls.
    }
    void ReturnCamMiddle()
    {
        camTransf.position = new Vector3(0, 0, -10);
    }

    void ChoseAscend()
    {
        uiManagerScript.AddToAscended();
        charScript.SwipeCharacterRight();
        score.AddA();
    }
    void ChoseReincarnate()
    {
        uiManagerScript.AddToReincarnated();
        charScript.SwipeCharacterLeft();
        score.AddB();
    }
}
