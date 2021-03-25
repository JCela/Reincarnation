using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{

    public float Cash;
    public Text cashText;
    public Text cashSign;

    void Start()
    {
        
    }

   
    void Update()
    {
        cashText.text = ""+Cash;

    }
}
