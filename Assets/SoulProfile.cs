using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoulProfile : MonoBehaviour
{


    private TagScript tagScript;

    
    private TextMeshPro T1Text;
    public GameObject T1;







    // Start is called before the first frame update
    void Start()
    {
        GameObject Profile1 = GameObject.Find("TagPrefab");
        tagScript = Profile1.GetComponent<TagScript>();
        T1 = this.transform.GetChild(0).gameObject;
      


    }

    // Update is called once per frame
    void Update()
    {
        ProfileSpawn();
    }

    public void ProfileSpawn()
    {




        T1Text = T1.GetComponent<TextMeshPro>();
        T1Text.text = tagScript.settag.text;

    }

}
