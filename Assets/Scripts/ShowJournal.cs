using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowJournal : MonoBehaviour
{
    private GameObject journal;
    private GameObject JContainer;
    private GameObject noti;
    private GameObject UIContainer;
    public Text journalText;
    private GameObject jText;
    private bool menuOn = false;
    private bool notified = false;
    // Start is called before the first frame update
    void Start()
    {
        //journal = GameObject.FindWithTag("Journal");
    }

    // Update is called once per frame
    void Update()
    {
        JContainer = GameObject.FindWithTag("Journal");
        journal = JContainer.transform.GetChild(1).gameObject;
        noti = GameObject.FindWithTag("Noti4");
        UIContainer = GameObject.FindWithTag("JournalText");
        journalText = UIContainer.transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Text>();
        jText = UIContainer.transform.GetChild(0).gameObject;
        

        if(State.Entry == 0)
        {
            journalText.text = "I don't know what to make of this place, I still don't know how I died.  I can't remember anything about my life.";
        }else if(State.Entry == 1)
        {
            journalText.text = "Of course two days in and someone comes through that I killed.  I was meticulous with my kills, and made sure to leave nothing to chance.  But of course, after 17 kills, arrogance started to kick in.  Seeing her today was a reminder of what got me here, and off the earth, away from Catrina.  Maybe this is a new beginning for me. ";
        }else if(State.Entry == 2)
        {
            journalText.text = "Seeing all these people I killed, am I truly damned if I dont give them a second chance at life? This all makes me wonder, will I get a second chance at life?  Will I finally make it to Heaven?";
        }
        //journal = GameObject.FindWithTag("Journal");
    }

    public void OnMouseDown()
    {
        if (menuOn == true)
        {
            journal.SetActive(false);
            jText.SetActive(false);
            menuOn = false;
        }
        else
        {
            journal.SetActive(true);
            jText.SetActive(true);
            menuOn = true;
        }

        if (notified == false)
        {
            //telephoneAnimator.SetBool("needStretch", false);
            noti.SetActive(false);
            notified = true;
        }
    }
}
