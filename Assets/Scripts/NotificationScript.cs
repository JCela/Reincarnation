using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationScript : MonoBehaviour
{
    private GameObject noti;

    void Start()
    {
        noti = GameObject.FindWithTag("Noti2");
    }

    public void OnMouseDown()
    {

        noti.SetActive(false);
    }
}
