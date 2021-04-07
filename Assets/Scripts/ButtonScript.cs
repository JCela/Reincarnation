using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
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
        Ascend();
        //cs.pressedUp = false;
        //cs.pressedDown = false;
    }
}
