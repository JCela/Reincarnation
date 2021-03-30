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
    private TextMeshPro tag;

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
        tag = tagText.GetComponent<TextMeshPro>();
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

    private void WriteTags()
    {
        if (random == 0)
        {
            if (moral >= 5)//Positive
            {
                
                //Choose random moral tag
                switch (randomText)
                {
                    case 0:
                        tag.SetText("Altruist");
                        Addpoint(1);
                        break;
                    case 1:
                        tag.SetText("Generous");
                        Addpoint(3);
                        break;
                    case 2:
                        tag.SetText("Parent");
                        Addpoint(5);
                        break;
                    case 3:
                        tag.SetText("Conservationist");
                        Addpoint(1);
                        break;
                    case 4:
                        tag.SetText("Charity Worker");
                        Addpoint(1);
                        break;
                    case 5:
                        tag.SetText("Volunteer");
                        Addpoint(2);
                        break;
                    case 6:
                        tag.SetText("Teacher");
                        Addpoint(2);
                        break;
                    case 7:
                        tag.SetText("Donater");
                        Addpoint(1);
                        break;
                    case 8:
                        tag.SetText("Selfless");
                        Addpoint(2);
                        break;
                    case 9:
                        tag.SetText("Altruist");
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
                        tag.SetText("Egoist");
                        Losepoint(2);
                        break;
                    case 1:
                        tag.SetText("Criminal");
                        Losepoint(5);
                        break;
                    case 2:
                        tag.SetText("Murderer");
                        Losepoint(5);
                        break;
                    case 3:
                        tag.SetText("Vandal");
                        Losepoint(3);
                        break;
                    case 4:
                        tag.SetText("Litter bug");
                        Losepoint(1);
                        break;
                    case 5:
                        tag.SetText("Flusher");
                        Losepoint(1);
                        break;
                    case 6:
                        tag.SetText("Farter");
                        Losepoint(1);
                        break;
                    case 7:
                        tag.SetText("Gluton");
                        Losepoint(1);
                        break;
                    case 8:
                        tag.SetText("Lustful");
                        Losepoint(3);
                        break;
                    case 9:
                        tag.SetText("Cheater");
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
                        tag.SetText("Traveler");
                        Addpoint(2);
                        break;
                    case 1:
                        tag.SetText("CEO");
                        Addpoint(1);
                        break;
                    case 2:
                        tag.SetText("Author");
                        Addpoint(4);
                        break;
                    case 3:
                        tag.SetText("Married");
                        Addpoint(4);
                        break;
                    case 4:
                        tag.SetText("Single Parent");
                        Addpoint(3);
                        break;
                    case 5:
                        tag.SetText("Educated");
                        Addpoint(2);
                        break;
                    case 6:
                        tag.SetText("Graduate");
                        Addpoint(2);
                        break;
                    case 7:
                        tag.SetText("Executive");
                        Addpoint(3);
                        break;
                    case 8:
                        tag.SetText("Retired");
                        Addpoint(3);
                        break;
                    case 9:
                        tag.SetText("Profitable");
                        Addpoint(3);
                        break;
                }
            }
            else
            {
                
                switch (randomText)
                {
                    case 0:
                        tag.SetText("Coach Potato");
                        Losepoint(1);
                        break;
                    case 1:
                        tag.SetText("Cheater");
                        Losepoint(3);
                        break;
                    case 2:
                        tag.SetText("Single");
                        Losepoint(1);
                        break;
                    case 3:
                        tag.SetText("Uneducated");
                        Losepoint(3);
                        break;
                    case 4:
                        tag.SetText("Hacker");
                        Losepoint(5);
                        break;
                    case 5:
                        tag.SetText("Stoner");
                        Losepoint(1);
                        break;
                    case 6:
                        tag.SetText("Scammer");
                        Losepoint(5);
                        break;
                    case 7:
                        tag.SetText("Lonely");
                        Losepoint(2);
                        break;
                    case 8:
                        tag.SetText("Confused");
                        Losepoint(1);
                        break;
                    case 9:
                        tag.SetText("Lost");
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
                        tag.SetText("Married Once");
                        Addpoint(1);
                        break;
                    case 1:
                        tag.SetText("Social Hub");
                        Addpoint(3);
                        break;
                    case 2:
                        tag.SetText("Trustworthy");
                        Addpoint(3);
                        break;
                    case 3:
                        tag.SetText("Reliable");
                        Addpoint(2);
                        break;
                    case 4:
                        tag.SetText("Best friend");
                        Addpoint(3);
                        break;
                    case 5:
                        tag.SetText("Bud");
                        Addpoint(2);
                        break;
                    case 6:
                        tag.SetText("Real one");
                        Addpoint(5);
                        break;
                    case 7:
                        tag.SetText("FILLER");
                        Addpoint(1);
                        break;
                    case 8:
                        tag.SetText("FILLER");
                        Addpoint(1);
                        break;
                    case 9:
                        tag.SetText("FILLER");
                        Addpoint(1);
                        break;
                }
            }
            else
            {
                
                switch (randomText)
                {
                    case 0:
                        tag.SetText("Married Twice");
                        Losepoint(3);
                        break;
                    case 1:
                        tag.SetText("Robber");
                        Losepoint(5);
                        break;
                    case 2:
                        tag.SetText("Stealer");
                        Losepoint(4);
                        break;
                    case 3:
                        tag.SetText("Thief");
                        Losepoint(4);
                        break;
                    case 4:
                        tag.SetText("Cheater");
                        Losepoint(4);
                        break;
                    case 5:
                        tag.SetText("Enemy");
                        Losepoint(5);
                        break;
                    case 6:
                        tag.SetText("Stranger");
                        Losepoint(1);
                        break;
                    case 7:
                        tag.SetText("Unknown");
                        Losepoint(2);
                        break;
                    case 8:
                        tag.SetText("Bearded");
                        Addpoint(1);
                        break;
                    case 9:
                        tag.SetText("Quiet");
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
                        tag.SetText("Strong");
                        Addpoint(2);
                        break;
                    case 1:
                        tag.SetText("Brave");
                        Addpoint(3);
                        break;
                    case 2:
                        tag.SetText("Leader");
                        Addpoint(5);
                        break;
                    case 3:
                        tag.SetText("Tough");
                        Addpoint(1);
                        break;
                    case 4:
                        tag.SetText("Unkillable");
                        Addpoint(2);
                        break;
                    case 5:
                        tag.SetText("Trustworthy");
                        Addpoint(5);
                        break;
                    case 6:
                        tag.SetText("Unchanging");
                        Addpoint(2);
                        break;
                    case 7:
                        tag.SetText("Unwavering");
                        Addpoint(3);
                        break;
                    case 8:
                        tag.SetText("Revolutionary");
                        Addpoint(5);
                        break;
                    case 9:
                        tag.SetText("Prideful");
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
                        tag.SetText("Team Flipper");
                        break;
                    case 1:
                        tag.SetText("Snitch");
                        break;
                    case 2:
                        tag.SetText("Snake");
                        break;
                    case 3:
                        tag.SetText("Rat");
                        break;
                    case 4:
                        tag.SetText("Dishonest");
                        break;
                    case 5:
                        tag.SetText("Self concious");
                        break;
                    case 6:
                        tag.SetText("Nepotist");
                        break;
                    case 7:
                        tag.SetText("Unfair boss");
                        break;
                    case 8:
                        tag.SetText("Propogandor");
                        break;
                    case 9:
                        tag.SetText("Liar");
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
