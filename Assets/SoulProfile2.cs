using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoulProfile2 : MonoBehaviour
{

    
    private TagScript tagScript2;
    public GameObject T2;

    private TextMeshPro T2Text;
   








    // Start is called before the first frame update
    void Start()
    {
        

        GameObject Profile2 = GameObject.Find("TagPrefaba");
        tagScript2 = Profile2.GetComponent<TagScript>();
        T2 = this.transform.GetChild(0).gameObject;



    }

    // Update is called once per frame
    void Update()
    {
        ProfileSpawn();
    }

    public void ProfileSpawn()
    {
        T2Text = T2.GetComponent<TextMeshPro>();
        T2Text.text = tagScript2.settag.text;
    }

}
