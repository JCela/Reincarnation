using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileDisplay : MonoBehaviour
{
    public Text VirtueText;
    public Text FulText;
    public Text GSText;
    public Text NameText;

    public newAttributeTest reference;
    public randomNameGenerator nameRef;

    // Start is called before the first frame update
    void Start()
    {
        reference = GetComponent<newAttributeTest>();
        nameRef = GetComponent<randomNameGenerator>();
        
    }


    void DisplayText()
    {
        reference.RandomCharacter();
        nameRef.GetRandomName();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayText();
        }
    }
}
