using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TagScript : MonoBehaviour
{
    private IEnumerator inittags;
    

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
    }

    void Update()
    {

        character = GameObject.FindWithTag("Character");
        charscript = character.GetComponent<CharacterScript>();
 
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

                        break;
                    case 1:
                        tag.SetText("Generous");
                        break;
                    case 2:
                        tag.SetText("Foster Parent");
                        break;
                    case 3:
                        tag.SetText("Conservationist");
                        break;
                    case 4:
                        tag.SetText("Charity Worker");
                        break;
                    case 5:
                        tag.SetText("Volunteer");
                        break;
                    case 6:
                        tag.SetText("Teacher");
                        break;
                    case 7:
                        tag.SetText("Donater");
                        break;
                    case 8:
                        tag.SetText("Selfless");
                        break;
                    case 9:
                        tag.SetText("Altruist");
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
                        break;
                    case 1:
                        tag.SetText("Criminal");
                        break;
                    case 2:
                        tag.SetText("Murderer");
                        break;
                    case 3:
                        tag.SetText("Vandal");
                        break;
                    case 4:
                        tag.SetText("Litter bug");
                        break;
                    case 5:
                        tag.SetText("Doesn't Flush");
                        break;
                    case 6:
                        tag.SetText("Seat Leaver Upper");
                        break;
                    case 7:
                        tag.SetText("Gluton");
                        break;
                    case 8:
                        tag.SetText("Lustful");
                        break;
                    case 9:
                        tag.SetText("Cheater");
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
                        break;
                    case 1:
                        tag.SetText("CEO");
                        break;
                    case 2:
                        tag.SetText("Author");
                        break;
                    case 3:
                        tag.SetText("Married");
                        break;
                    case 4:
                        tag.SetText("Single Parent");
                        break;
                    case 5:
                        tag.SetText("Educated");
                        break;
                    case 6:
                        tag.SetText("Graduate");
                        break;
                    case 7:
                        tag.SetText("Executive");
                        break;
                    case 8:
                        tag.SetText("Retired");
                        break;
                    case 9:
                        tag.SetText("Profitable");
                        break;
                }
            }
            else
            {
                switch (randomText)
                {
                    case 0:
                        tag.SetText("Coach Potato");
                        break;
                    case 1:
                        tag.SetText("Cheater");
                        break;
                    case 2:
                        tag.SetText("Single");
                        break;
                    case 3:
                        tag.SetText("Uneducated");
                        break;
                    case 4:
                        tag.SetText("Hacker");
                        break;
                    case 5:
                        tag.SetText("Stoner");
                        break;
                    case 6:
                        tag.SetText("Scammer");
                        break;
                    case 7:
                        tag.SetText("Lonely");
                        break;
                    case 8:
                        tag.SetText("Confused");
                        break;
                    case 9:
                        tag.SetText("Lost");
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
                        break;
                    case 1:
                        tag.SetText("Social Hub");
                        break;
                    case 2:
                        tag.SetText("Trustworthy");
                        break;
                    case 3:
                        tag.SetText("Reliable");
                        break;
                    case 4:
                        tag.SetText("Best friend");
                        break;
                    case 5:
                        tag.SetText("Bud");
                        break;
                    case 6:
                        tag.SetText("Real one");
                        break;
                    case 7:
                        tag.SetText("FILLER");
                        break;
                    case 8:
                        tag.SetText("FILLER");
                        break;
                    case 9:
                        tag.SetText("FILLER");
                        break;
                }
            }
            else
            {
                switch (randomText)
                {
                    case 0:
                        tag.SetText("Married Many Times ;)");
                        break;
                    case 1:
                        tag.SetText("Robber");
                        break;
                    case 2:
                        tag.SetText("Stealer");
                        break;
                    case 3:
                        tag.SetText("Thief");
                        break;
                    case 4:
                        tag.SetText("Cheater");
                        break;
                    case 5:
                        tag.SetText("Enemy");
                        break;
                    case 6:
                        tag.SetText("Stranger");
                        break;
                    case 7:
                        tag.SetText("Unknown");
                        break;
                    case 8:
                        tag.SetText("Bearded");
                        break;
                    case 9:
                        tag.SetText("Quiet");
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
                        break;
                    case 1:
                        tag.SetText("Brave");
                        break;
                    case 2:
                        tag.SetText("Leader");
                        break;
                    case 3:
                        tag.SetText("Tough");
                        break;
                    case 4:
                        tag.SetText("Unkillable");
                        break;
                    case 5:
                        tag.SetText("Trustworthy");
                        break;
                    case 6:
                        tag.SetText("Unchanging");
                        break;
                    case 7:
                        tag.SetText("Unwavering");
                        break;
                    case 8:
                        tag.SetText("Revolutionary");
                        break;
                    case 9:
                        tag.SetText("Prideful");
                        break;
                }
            }
            else
            {
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
                        tag.SetText("Propoganda Spreader");
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

    public void OnMouseDown()
    {
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
}
