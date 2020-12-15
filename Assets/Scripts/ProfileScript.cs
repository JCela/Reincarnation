using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileScript : MonoBehaviour
{
    public Sprite[] pics;
    int i;
 
    void Start()
    {
        i = Random.Range(0, 9);
    }

    void Update()
    {
        this.GetComponent<SpriteRenderer>().sprite = pics[i];
    }
}
