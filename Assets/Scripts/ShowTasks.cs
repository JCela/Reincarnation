﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTasks : MonoBehaviour
{

    private GameObject tasks;
    private GameObject taskContainer;
    private GameObject UIContainter;
    private GameObject bossIcon;
    private GameObject noti;
    private bool notified = false;

    private bool taskOn = false;
    // Start is called before the first frame update
    void Start()
    {
        taskContainer = GameObject.FindWithTag("Task Container");
        UIContainter = GameObject.FindWithTag("UIText");
    }

    // Update is called once per frame
    void Update()
    {
        bossIcon = taskContainer.transform.GetChild(0).gameObject;
        tasks = UIContainter.transform.GetChild(5).gameObject;
        noti = GameObject.FindWithTag("Noti1");
    }

    public void OnMouseDown()
    {
        if (taskOn == true)
        {
            bossIcon.SetActive(false);
            tasks.SetActive(false);
            taskOn = false;
        }
        else
        {
            bossIcon.SetActive(true);
            tasks.SetActive(true);
            taskOn = true;
        }

        if (notified == false)
        {
            noti.SetActive(false);
            notified = true;
        }
        
    }
}
