using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTagScript : MonoBehaviour
{

    private GameObject character;
    private GameObject[] profile = new GameObject[3];
    private GameObject noti;

    private bool notified = false;

    private bool profileOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        character = GameObject.FindWithTag("Character");
        //profile[0] = character.transform.GetChild(0).gameObject;
        profile[1] = character.transform.GetChild(1).gameObject;
        profile[2] = character.transform.GetChild(2).gameObject;
        noti = GameObject.FindWithTag("Noti5");
    }

    public void OnMouseDown()
    {
        if (profileOn == true)
        {
            //profile[0].SetActive(false);
            profile[1].SetActive(false);
            profile[2].SetActive(false);
            profileOn = false;
        }
        else
        {
            //profile[0].SetActive(true);
            profile[1].SetActive(true);
            profile[2].SetActive(true);
            profileOn = true;
        }

        if (notified == false)
        {
            noti.SetActive(false);
            notified = true;
        }
    }
}
