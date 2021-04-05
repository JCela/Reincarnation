using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TagScript : MonoBehaviour
{
    private IEnumerator inittags;
    SpriteRenderer sprite;

    private CharacterScript charscript;
    private GameObject character;
    private GameObject overlay;
    private GameObject chatSpawn;

    public int moral;
    public int actualization;
    public int loyalty;
    public int integrity;

    public int random;
    public int randomText;

    public int currentPoints;
    public GameObject tagText;
    public TextMeshPro settag;

    public GameObject chatPrefab;

    private int lastNumber = 0;
    private int chatClicks = 0;
    public int clickableLimit = 2;
    

    void Start()
    {
        inittags = SetTagValues();
        StartCoroutine(inittags);
        random = GetRandom(0, 4);
        randomText = GetRandom(0, 9);
        overlay = GameObject.FindWithTag("Overlay");
        chatSpawn = overlay.transform.GetChild(0).gameObject;
        currentPoints = 0;
    }

    void Update()
    {

        character = GameObject.FindWithTag("Character");
        charscript = character.GetComponent<CharacterScript>();
        sprite = this.gameObject.GetComponent<SpriteRenderer>();
        tagText = this.transform.GetChild(0).gameObject;
        settag = tagText.GetComponent<TextMeshPro>();
    }

    private IEnumerator SetTagValues()
    {
        yield return new WaitForSeconds(0.5f);
        moral = charscript.LevelOfMoral;
        actualization = charscript.LevelOfActualization;
        loyalty = charscript.LevelOfLoyalty;
        integrity = charscript.LevelOfIntegrity;
        //Debug.Log("This is a debug test" + moral);

        WriteTags(); //take values and start writing
        StopCoroutine(inittags);    //stop setting values coroutine
    }

    public void WriteTags()
    {
        if (random == 0)
        {
            if (moral >= 5)//Positive
            {
                
                //Choose random moral tag
                switch (randomText)
                {
                    case 0:
                        settag.SetText("Altruist");
                        Addpoint(1);
                        break;
                    case 1:
                        settag.SetText("Generous");
                        Addpoint(3);
                        break;
                    case 2:
                        settag.SetText("Parent");
                        Addpoint(5);
                        break;
                    case 3:
                        settag.SetText("Conservationist");
                        Addpoint(1);
                        break;
                    case 4:
                        settag.SetText("Charity Worker");
                        Addpoint(1);
                        break;
                    case 5:
                        settag.SetText("Volunteer");
                        Addpoint(2);
                        break;
                    case 6:
                        settag.SetText("Teacher");
                        Addpoint(2);
                        break;
                    case 7:
                        settag.SetText("Donater");
                        Addpoint(1);
                        break;
                    case 8:
                        settag.SetText("Selfless");
                        Addpoint(2);
                        break;
                    case 9:
                        settag.SetText("Altruist");
                        Addpoint(3);
                        break;

                }
            }
            else
            {
                
                //Choose a random immoral tag
                switch (randomText)
                {
                    case 0:
                        settag.SetText("Egoist");
                        Losepoint(2);
                        break;
                    case 1:
                        settag.SetText("Criminal");
                        Losepoint(5);
                        break;
                    case 2:
                        settag.SetText("Murderer");
                        Losepoint(5);
                        break;
                    case 3:
                        settag.SetText("Vandal");
                        Losepoint(3);
                        break;
                    case 4:
                        settag.SetText("Litter bug");
                        Losepoint(1);
                        break;
                    case 5:
                        settag.SetText("Flusher");
                        Losepoint(1);
                        break;
                    case 6:
                        settag.SetText("Farter");
                        Losepoint(1);
                        break;
                    case 7:
                        settag.SetText("Gluton");
                        Losepoint(1);
                        break;
                    case 8:
                        settag.SetText("Lustful");
                        Losepoint(3);
                        break;
                    case 9:
                        settag.SetText("Cheater");
                        Losepoint(4);
                        break;
                }

            }
        }
        else if(random == 1)
        {
            if (actualization >= 5)
            {
                
                switch (randomText)
                {
                    case 0:
                        settag.SetText("Traveler");
                        Addpoint(2);
                        break;
                    case 1:
                        settag.SetText("CEO");
                        Addpoint(1);
                        break;
                    case 2:
                        settag.SetText("Author");
                        Addpoint(4);
                        break;
                    case 3:
                        settag.SetText("Married");
                        Addpoint(4);
                        break;
                    case 4:
                        settag.SetText("Single Parent");
                        Addpoint(3);
                        break;
                    case 5:
                        settag.SetText("Educated");
                        Addpoint(2);
                        break;
                    case 6:
                        settag.SetText("Graduate");
                        Addpoint(2);
                        break;
                    case 7:
                        settag.SetText("Executive");
                        Addpoint(3);
                        break;
                    case 8:
                        settag.SetText("Retired");
                        Addpoint(3);
                        break;
                    case 9:
                        settag.SetText("Profitable");
                        Addpoint(3);
                        break;
                }
            }
            else
            {
                
                switch (randomText)
                {
                    case 0:
                        settag.SetText("Coach Potato");
                        Losepoint(1);
                        break;
                    case 1:
                        settag.SetText("Cheater");
                        Losepoint(3);
                        break;
                    case 2:
                        settag.SetText("Single");
                        Losepoint(1);
                        break;
                    case 3:
                        settag.SetText("Uneducated");
                        Losepoint(3);
                        break;
                    case 4:
                        settag.SetText("Hacker");
                        Losepoint(5);
                        break;
                    case 5:
                        settag.SetText("Stoner");
                        Losepoint(1);
                        break;
                    case 6:
                        settag.SetText("Scammer");
                        Losepoint(5);
                        break;
                    case 7:
                        settag.SetText("Lonely");
                        Losepoint(2);
                        break;
                    case 8:
                        settag.SetText("Confused");
                        Losepoint(1);
                        break;
                    case 9:
                        settag.SetText("Lost");
                        Losepoint(2);
                        break;
                }
            }
        }
        else if(random == 2)
        {
            if (loyalty >= 5)
            {
                
                switch (randomText)
                {
                    case 0:
                        settag.SetText("Married Once");
                        Addpoint(1);
                        break;
                    case 1:
                        settag.SetText("Social Hub");
                        Addpoint(3);
                        break;
                    case 2:
                        settag.SetText("Trustworthy");
                        Addpoint(3);
                        break;
                    case 3:
                        settag.SetText("Reliable");
                        Addpoint(2);
                        break;
                    case 4:
                        settag.SetText("Best friend");
                        Addpoint(3);
                        break;
                    case 5:
                        settag.SetText("Bud");
                        Addpoint(2);
                        break;
                    case 6:
                        settag.SetText("Real one");
                        Addpoint(5);
                        break;
                    case 7:
                        settag.SetText("FILLER");
                        Addpoint(1);
                        break;
                    case 8:
                        settag.SetText("FILLER");
                        Addpoint(1);
                        break;
                    case 9:
                        settag.SetText("FILLER");
                        Addpoint(1);
                        break;
                }
            }
            else
            {
                
                switch (randomText)
                {
                    case 0:
                        settag.SetText("Married Twice");
                        Losepoint(3);
                        break;
                    case 1:
                        settag.SetText("Robber");
                        Losepoint(5);
                        break;
                    case 2:
                        settag.SetText("Stealer");
                        Losepoint(4);
                        break;
                    case 3:
                        settag.SetText("Thief");
                        Losepoint(4);
                        break;
                    case 4:
                        settag.SetText("Cheater");
                        Losepoint(4);
                        break;
                    case 5:
                        settag.SetText("Enemy");
                        Losepoint(5);
                        break;
                    case 6:
                        settag.SetText("Stranger");
                        Losepoint(1);
                        break;
                    case 7:
                        settag.SetText("Unknown");
                        Losepoint(2);
                        break;
                    case 8:
                        settag.SetText("Bearded");
                        Addpoint(1);
                        break;
                    case 9:
                        settag.SetText("Quiet");
                        Losepoint(2);
                        break;
                }
            }
        }
        else if(random == 3)
        {
            if(integrity >= 5)
            {
                
                switch (randomText)
                {
                    case 0:
                        settag.SetText("Strong");
                        Addpoint(2);
                        break;
                    case 1:
                        settag.SetText("Brave");
                        Addpoint(3);
                        break;
                    case 2:
                        settag.SetText("Leader");
                        Addpoint(5);
                        break;
                    case 3:
                        settag.SetText("Tough");
                        Addpoint(1);
                        break;
                    case 4:
                        settag.SetText("Unkillable");
                        Addpoint(2);
                        break;
                    case 5:
                        settag.SetText("Trustworthy");
                        Addpoint(5);
                        break;
                    case 6:
                        settag.SetText("Unchanging");
                        Addpoint(2);
                        break;
                    case 7:
                        settag.SetText("Unwavering");
                        Addpoint(3);
                        break;
                    case 8:
                        settag.SetText("Revolutionary");
                        Addpoint(5);
                        break;
                    case 9:
                        settag.SetText("Prideful");
                        Addpoint(1);
                        break;
                }
            }
            else
            {
                Losepoint(5);
                switch (randomText)
                {
                    case 0:
                        settag.SetText("Team Flipper");
                        break;
                    case 1:
                        settag.SetText("Snitch");
                        break;
                    case 2:
                        settag.SetText("Snake");
                        break;
                    case 3:
                        settag.SetText("Rat");
                        break;
                    case 4:
                        settag.SetText("Dishonest");
                        break;
                    case 5:
                        settag.SetText("Self concious");
                        break;
                    case 6:
                        settag.SetText("Nepotist");
                        break;
                    case 7:
                        settag.SetText("Unfair boss");
                        break;
                    case 8:
                        settag.SetText("Propogandor");
                        break;
                    case 9:
                        settag.SetText("Liar");
                        break;
                }
            }
        }

    }

    int GetRandom(int min, int max)
    {
        int rand = Random.Range(min, max);
        while (rand == lastNumber)
            rand = Random.Range(min, max);
        lastNumber = rand;
        return rand;
    }

    public void Addpoint(int amount)
    {
        currentPoints += amount;
    }

    public void Losepoint(int amount)
    {
        currentPoints -= amount;
    }
    public void OnMouseDown()
    {
        FadeTag();
        if (chatClicks < 1 && charscript.charClicks < clickableLimit)
        {
            GameObject bubble = (GameObject)Instantiate(chatPrefab, chatSpawn.transform.position, transform.rotation);
            bubble.transform.parent = overlay.transform;
            ChatScript cs = bubble.GetComponent<ChatScript>();
            cs.WriteBubble(random, randomText, moral, integrity, loyalty, actualization, 0);
            chatClicks++;
            charscript.charClicks++;

        }
    }

    

    public void FadeTag()
    {
        Debug.Log("Reached");
        sprite.color = new Color(1f,1f,1f,0.5f);
    }
}
