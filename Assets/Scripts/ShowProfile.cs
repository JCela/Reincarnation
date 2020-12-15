using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowProfile : MonoBehaviour
{
    private GameObject character;
    private GameObject profile;

    private bool profileOn = false;

    // Update is called once per frame
    void Update()
    {
        character = GameObject.FindWithTag("Character");
        profile = character.transform.GetChild(3).gameObject;
    }

    public void OnMouseDown()
    {
        if(profileOn == true)
        {
            profile.SetActive(false);
            profileOn = false;
        }
        else { 
            profile.SetActive(true);
            profileOn = true;
        }
    }
}
