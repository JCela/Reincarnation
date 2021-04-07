using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{

    public static float score;
    //public static int currentTask;

    void Start()
    {
        Debug.Log("State Score:" + score);
    }
}
