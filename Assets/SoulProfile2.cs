using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoulProfile2 : MonoBehaviour
{

    
    private TagScript tagScript2;
    private CharacterScript charscript;

    public GameObject T2;

    private TextMeshPro T2Text;

    private GameObject overlay;
    private GameObject chatSpawn;

    public SpriteRenderer sprite;
  
    //public float transTime;
    //public bool isMouseOver;

    private GameObject character;
    public GameObject chatPrefab;


    private int lastNumber = 0;
    private int chatClicks = 0;
    public int clickableLimit = 2;

    private int s2_moral;
    private int s2_actualization;
    private int s2_loyalty;
    private int s2_integrity;

    private int s2_random;
    private int s2_randomText;









    // Start is called before the first frame update
    void Start()
    {

        character = GameObject.FindWithTag("Character");


        GameObject Profile2 = GameObject.FindWithTag("tag2");
        tagScript2 = Profile2.GetComponent<TagScript>();
        T2 = this.transform.GetChild(0).gameObject;

        overlay = GameObject.FindWithTag("Overlay");
        chatSpawn = overlay.transform.GetChild(0).gameObject;

        charscript = character.GetComponent<CharacterScript>();
        sprite = this.gameObject.GetComponent<SpriteRenderer>();


        s2_moral = tagScript2.moral;
        s2_actualization = tagScript2.actualization;
        s2_loyalty = tagScript2.loyalty;
        s2_integrity = tagScript2.integrity;
        s2_random = tagScript2.random;
        s2_randomText = tagScript2.randomText;

        
        
        
        //isMouseOver = false;

        
        

    }

    // Update is called once per frame
    void Update()
    {

        //Color alpha = sprite.color;
        //alpha.a = 0f;
        //if (isMouseOver == true)
        //{
        //    alpha.a = alpha.a + 1f * (Time.deltaTime * transTime);
        //}
        //else
        //{
        //    alpha.a = alpha.a - 1f * (Time.deltaTime * transTime);
        //}

        character = GameObject.FindWithTag("Character");


        GameObject Profile2 = GameObject.FindWithTag("tag2");
        tagScript2 = Profile2.GetComponent<TagScript>();
        T2 = this.transform.GetChild(0).gameObject;

        overlay = GameObject.FindWithTag("Overlay");
        chatSpawn = overlay.transform.GetChild(0).gameObject;

        charscript = character.GetComponent<CharacterScript>();
        sprite = this.gameObject.GetComponent<SpriteRenderer>();


        s2_moral = tagScript2.moral;
        s2_actualization = tagScript2.actualization;
        s2_loyalty = tagScript2.loyalty;
        s2_integrity = tagScript2.integrity;
        s2_random = tagScript2.random;
        s2_randomText = tagScript2.randomText;

        ProfileSpawn();
    }

    public void ProfileSpawn()
    {
        T2Text = T2.GetComponent<TextMeshPro>();
        T2Text.text = tagScript2.settag.text;
    }


    public void OnMouseDown()
    {
        //FadeTag();
        if (chatClicks < 1 && charscript.charClicks < clickableLimit)
        {
            GameObject bubble = (GameObject)Instantiate(chatPrefab, chatSpawn.transform.position, transform.rotation);
            bubble.transform.parent = overlay.transform;
            ChatScript cs = bubble.GetComponent<ChatScript>();
            cs.WriteBubble(s2_random, s2_randomText, s2_moral, s2_integrity, s2_loyalty, s2_actualization, 0);
            chatClicks++;
            charscript.charClicks++;

        }
    }


    //public void OnMouseEnter()
    //{
    //    isMouseOver = true;
    //    Debug.Log("enter");
    //}

    //public void OnMouseExit()
    //{
    //    isMouseOver = false;
    //    Debug.Log("exit");
    //}





    public void FadeTag()
    {
        Debug.Log("Reached");
        sprite.color = new Color(1f, 1f, 1f, 0.5f);
    }
}
