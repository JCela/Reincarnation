using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testNameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var nameGenerator = GetComponent<randomNameGenerator>();
        Debug.Log(nameGenerator.GetRandomName());
    }
}
