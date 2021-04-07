using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoulProfile : MonoBehaviour
{


    private TagScript tagScript;
    private CharacterScript charscript;


    private TextMeshPro T1Text;
    public GameObject T1;

    private GameObject overlay;
    private GameObject chatSpawn;

    SpriteRenderer sprite;

    private GameObject character;
    public GameObject chatPrefab;
    private int lastNumber = 0;
    private int chatClicks = 0;
    public int clickableLimit = 2;

    private int s1_moral;
    private int s1_actualization;
    private int s1_loyalty;
    private int s1_integrity;

    private int s1_random;
    private int s1_randomText;







    // Start is called before the first frame update
    void Start()
    {


       



    }

    // Update is called once per frame
    void Update()
    {
        character = GameObject.FindWithTag("Character");
        GameObject Profile1 = GameObject.FindWithTag("tag1");

        //GameObject Profile1 = GameObject.Find("TagPrefab");
        //tagScript = Profile1.GetComponent<TagScript>();
        //T1 = this.transform.GetChild(0).gameObject;

        overlay = GameObject.FindWithTag("Overlay");
       
        

        charscript = character.GetComponent<CharacterScript>();
        tagScript = Profile1.GetComponent<TagScript>();

        chatSpawn = overlay.transform.GetChild(0).gameObject;




        s1_moral = tagScript.moral;
        s1_actualization = tagScript.actualization;
        s1_loyalty = tagScript.loyalty;
        s1_integrity = tagScript.integrity;
        s1_random = tagScript.random;
        s1_randomText = tagScript.randomText;



        ProfileSpawn();
    }

    public void ProfileSpawn()
    {


        


        
       
        T1 = this.transform.GetChild(0).gameObject;


        T1Text = T1.GetComponent<TextMeshPro>();
        T1Text.text = tagScript.settag.text;

    }

    public void OnMouseDown()
    {
        //FadeTag();
        if (chatClicks < 1 && charscript.charClicks < clickableLimit)
        {
            GameObject bubble = (GameObject)Instantiate(chatPrefab, chatSpawn.transform.position, transform.rotation);
            bubble.transform.parent = overlay.transform;
            ChatScript cs = bubble.GetComponent<ChatScript>();
            cs.WriteBubble(s1_random, s1_randomText, s1_moral, s1_integrity, s1_loyalty, s1_actualization, 0);
            chatClicks++;
            charscript.charClicks++;

        }
    }



    //public void FadeTag()
    //{
    //    Debug.Log("Reached");
    //    sprite.color = new Color(1f, 1f, 1f, 0.5f);
    //}

}
