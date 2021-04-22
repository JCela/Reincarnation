using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    private GameObject manager;
    private CameraSwipe cs;

    void Start()
    {
        manager = GameObject.FindWithTag("Manager");
        cs = manager.GetComponent<CameraSwipe>();
    }
    public void Ascend()
    {
        Debug.Log("Reached");
        cs.pressedUp = true;
    }
    public void Descend()
    {
        cs.pressedDown = true;
    }

    public void OnMouseDown()
    {
        Descend();
        //cs.pressedUp = false;
        //cs.pressedDown = false;
    }
}
