using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialText : MonoBehaviour
{
    private int dialogueIndex;
    public Text activeDialogue;
    public float timer = 0;

    public GameObject player;
    public GameObject target;
    public GameObject newTarget;
    public GameObject oldTarget;
    public GameObject boss;
    public GameObject bossTarget;

    public GameObject blackscreen;

    public Vector3 smallerText;
    public Vector3 largerText;
    public Vector3 direction;
    public Vector3 bossoffset;

    public float speed = 1;
    public Vector3 offset;

   
   
    void Start()
    {
        //blackscreen = GameObject.FindWithTag("BlackScreen");
    }


    void Update()
    {
        timer++;

        if (timer > 750 && timer < 1250)
        {
            dialogueIndex = 1;
        }else if(timer > 1250 && timer < 2000)
        {
            dialogueIndex = 2;
        }else if(timer > 2000 && timer < 3500)
        {
            player.transform.position = Vector3.Lerp(player.transform.position, (target.transform.position + offset), speed);
            dialogueIndex = 3;
        }else if(timer > 3500 && timer < 4300)
        {
            dialogueIndex = 4;
        }
        else if (timer > 4300 && timer < 5000)
        {
            dialogueIndex = 5;
        }
        else if (timer > 5000 && timer < 6000)
        {
            dialogueIndex = 6;
        }
        else if (timer > 6000 && timer < 7000)
        {
            dialogueIndex = 7;
        }
        else if (timer > 7000 && timer < 8000)
        {
            dialogueIndex = 8;
        }
        else if (timer > 8000 && timer < 9000)
        {
            dialogueIndex = 9;
        }
        else if (timer > 9000 && timer < 10000)
        {
            dialogueIndex = 10;
        }
        else if (timer > 10000 && timer < 11000)
        {
            dialogueIndex = 11;
        }
        else if (timer > 11000 && timer < 12000)
        {
            dialogueIndex = 12;
        }
        else if (timer > 12000 && timer < 13500)
        {
            dialogueIndex = 13;
        }
        else if (timer > 13500 && timer < 15000)
        {
            dialogueIndex = 14;
        }
        else if (timer > 15000 && timer < 16000)
        {
            dialogueIndex = 15;
        }
        else if (timer > 16000 && timer < 17000)
        {
            dialogueIndex = 16;
        }
        else if (timer > 17000 && timer < 17700)
        {
            dialogueIndex = 17;
        }
        else if (timer > 17700 && timer < 18000)
        {
            dialogueIndex = 18;
            boss.transform.position = Vector3.Lerp(boss.transform.position, (target.transform.position + bossoffset), speed);
        }
        else if (timer > 18000 && timer < 19000)
        {
            dialogueIndex = 19;
        }
        else if (timer > 19000 && timer < 20000)
        {
            dialogueIndex = 20;
        }
        else if (timer > 20000 && timer < 21000)
        {
            dialogueIndex = 21;
        }
        else if (timer > 21000 && timer < 22000)
        {
            dialogueIndex = 22;
        }
        else if (timer > 22000 && timer < 23000)
        {
            dialogueIndex = 23;
        }
        else if (timer > 23000 && timer < 24000)
        {
            dialogueIndex = 24;
        }
        else if (timer > 24000 && timer < 25000)
        {
            dialogueIndex = 25;
        }
        else if (timer > 25000 && timer < 26000)
        {
            dialogueIndex = 26;
        }
        else if (timer > 26000 && timer < 27000)
        {
            dialogueIndex = 27;
        }
        else if (timer > 27000 && timer < 28000)
        {
            dialogueIndex = 28;
        }
        else if (timer > 30000 && timer < 31000)
        {
            dialogueIndex = 29;
        }
        else if (timer > 31000 && timer < 32000)
        {
            dialogueIndex = 30;
        }
        else if (timer > 32000 && timer < 33000)
        {
            dialogueIndex = 31;
        }
        else if (timer > 33000 && timer < 34000)
        {
            dialogueIndex = 32;
        }
        else if (timer > 34000 && timer < 35000)
        {
            dialogueIndex = 33;
        }
        else if (timer > 35000 && timer < 36000)
        {
            dialogueIndex = 34;
            blackscreen.SetActive(true);
        }
        else if (timer > 36000)
        {
            SceneManager.LoadScene(1);
        }


        switch (dialogueIndex)
        {
            case 0:
                MakeTextBigger();
                activeDialogue.text = " ";
                break;
            case 1:
                activeDialogue.text = "What the... Where am I?";
                break;
            case 2:
                activeDialogue.text = "What is that over there?";
                break;
            case 3:
                activeDialogue.text = " ";
                break;
            case 4:
                MakeTextOfficer();
                activeDialogue.text = "What is your name?";
                break;
            case 5:
                MakeTextPlayer();
                activeDialogue.text = "I-I think it's Rhett";

                break;
            case 6:
                MakeTextOfficer();
                activeDialogue.text = "Hmmm... Welcome to the afterlife, Rhett.  I will be your soul sorter for today.";
                break;
            case 7:
                activeDialogue.text = "I will choose if you will be reincarnated or ascend to the afterlife.";
                break;
            case 8:
                MakeTextPlayer();
                activeDialogue.text = "Wow, it’s less… ";
                break;
            case 9:
                activeDialogue.text = "Glamorous...than I would have thought.";
                break;
            case 10:
                MakeTextOfficer();
                activeDialogue.text = "Your file is quite anomalous.  It says here that you took 17 lives.";
                break;
            case 11:
                activeDialogue.text = "Is that true? No point in lying by the way, you're already dead.";
                break;
            case 12:
                MakeTextPlayer();
                activeDialogue.text = "Your files are not wrong. I had urges I could not resist during my mortal life";
                break;
            case 13:
                MakeTextOfficer();
                activeDialogue.text = "I see... I will have to call my manager down for this.  Please wait here.";
                break;
            case 14:
                MakeTextSmaller();
                activeDialogue.text = "...hello sir?   He says he cannot remember anything...";
                break;
            case 15:
                activeDialogue.text = "...";
                break;
            case 16:
                activeDialogue.text = "Yes sir... see you soon sir...";
                break;
            case 17:
                MakeTextBigger();
                activeDialogue.text = "Just sit tight and my supervisor will be with you shortly!";
                break;
            case 18:
                MakeTextPlayer();
                activeDialogue.text = "Ok...";
                break;
            case 19:
                MakeTextBoss();
                activeDialogue.text = "Hello Rhett. I am the head of the Soul Processing Commision (SPC).";
                break;
            case 20:
                activeDialogue.text = "I was told you were a serial killer.";
                break;
            case 21:
                MakeTextPlayer();
                activeDialogue.text = "This is true.";
                break;
            case 22:
                MakeTextBoss();
                activeDialogue.text = "Alright, let me lay out the situation then.";
                break;
            case 23:
                activeDialogue.text = "As you already know, souls live individual lives every time they’re reincarnated...";
                break;
            case 24:                
                activeDialogue.text = "But certain traits have been reported to carry over.";
                break;
            case 25:
                activeDialogue.text = "The SPC believes serial killing is one of these traits.";
                break;
            case 26:
                MakeTextPlayer();
                activeDialogue.text = "Ok, so what does that mean for my soul?";
                break;
            case 27:
                MakeTextBoss();
                activeDialogue.text = "Well, we unfortunately can not risk reincarnating you.";
                break;
            case 28:
                activeDialogue.text = "We also can’t ascend you, because ascension requires a pure, fulfilled soul.";
                break;
            case 29:
                MakeTextPlayer();
                activeDialogue.text = "So where will I go?";
                break;
            case 30:
                MakeTextBoss();
                activeDialogue.text = "The most vile souls like yours must work for the SPC!";
                break;
            case 31:
                activeDialogue.text = " I will be assigning you to the sorting division...";
                break;
            case 32:
                activeDialogue.text = "If you complete your work perfectly, you may eventually judge your own soul.";
                break;
            case 33:
                activeDialogue.text = "Work starts... IMMEDIATLY.  Good luck!";
                break;
            case 34:
                MakeTextPlayer();
                activeDialogue.text = "...";
                break;






        }
    }

    void MakeTextOfficer()
    {
        activeDialogue.color = new Color(1, 0, 0, 100);
        activeDialogue.transform.position = newTarget.transform.position;
    }

    void MakeTextPlayer()
    {
        activeDialogue.color = new Color(0, 0, 0, 100);
        activeDialogue.transform.position = oldTarget.transform.position;
    }

    void MakeTextSmaller()
    {
        activeDialogue.transform.localScale = smallerText;
    }

    void MakeTextBigger()
    {
        activeDialogue.transform.localScale = largerText;
    }

    void MakeTextBoss()
    {
        activeDialogue.color = new Color(0, 0, 1, 100);
        activeDialogue.transform.position = bossTarget.transform.position;
    }
}
