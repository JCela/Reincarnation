using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{

    private GameObject character;
    private GameObject profile;
    private GameObject menu;

    private bool menuOn = false;

    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.FindWithTag("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        character = GameObject.FindWithTag("Character");
        profile = character.transform.GetChild(3).gameObject;
        
    }

    public void OnMouseDown()
    {
        if (menuOn == true)
        {
            menu.SetActive(false);
            menuOn = false;
        }
        else
        {
            menu.SetActive(true);
            menuOn = true;
        }
    }
}
