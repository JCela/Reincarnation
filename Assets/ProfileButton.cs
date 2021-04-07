using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileButton : MonoBehaviour
{
    public GameObject profileButton;
    public bool clickButtonSwitch;
    public bool isOn;


    // Start is called before the first frame update
    void Start()
    {
        clickButtonSwitch = false;
        isOn = false;
        profileButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (clickButtonSwitch && !isOn)
        {
            isOn = true;
            clickButtonSwitch = false;
           
        }

        if (clickButtonSwitch && isOn)
        {
            isOn = false;
            clickButtonSwitch = false;
           
        }

        showProfile();

    }

    public void OnMouseDown()
    {
        clickButtonSwitch = true;

       

    }

    public void showProfile()
    {
        if (isOn)
        {
            profileButton.SetActive(true);
        }else if (!isOn)
        {
            profileButton.SetActive(false);
        }
    }
}
