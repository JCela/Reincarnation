using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialText : MonoBehaviour
{
    private int dialogueIndex;
    public Text activeDialogue;
    public float timer = 1;
    public float time;

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
        timer+= Time.deltaTime;
        //time = timer * Time.deltaTime;

        if (timer > 5.0 && timer < 10.0)
        {
            dialogueIndex = 1;
        }else if(timer > 10 && timer < 15)
        {
            dialogueIndex = 2;
        }else if(timer > 15 && timer < 20)
        {
            player.transform.position = Vector3.Lerp(player.transform.position, (target.transform.position + offset), speed);
            dialogueIndex = 3;
        }else if(timer > 20 && timer < 25)
        {
            dialogueIndex = 4;
        }
        else if (timer > 25 && timer < 30)
        {
            dialogueIndex = 5;
        }
        else if (timer > 30 && timer < 35)
        {
            dialogueIndex = 6;
        }
        else if (timer > 35 && timer < 40)
        {
            dialogueIndex = 7;
        }
        else if (timer > 40 && timer < 45)
        {
            dialogueIndex = 8;
        }
        else if (timer > 45 && timer < 50)
        {
            dialogueIndex = 9;
        }
        else if (timer > 50 && timer < 55)
        {
            dialogueIndex = 10;
        }
        else if (timer > 60 && timer < 65)
        {
            dialogueIndex = 11;
        }
        else if (timer > 65 && timer < 70)
        {
            dialogueIndex = 12;
        }
        else if (timer > 70 && timer < 75)
        {
            dialogueIndex = 13;
        }
        else if (timer > 75 && timer < 80)
        {
            dialogueIndex = 14;
        }
        else if (timer > 80 && timer < 85)
        {
            dialogueIndex = 15;
        }
        else if (timer > 85 && timer < 90)
        {
            dialogueIndex = 16;
        }
        else if (timer > 90 && timer < 95)
        {
            dialogueIndex = 17;
        }
        else if (timer > 95 && timer < 100)
        {
            dialogueIndex = 18;
            boss.transform.position = Vector3.Lerp(boss.transform.position, (target.transform.position + bossoffset), speed);
        }
        else if (timer > 100 && timer < 105)
        {
            dialogueIndex = 19;
        }
        else if (timer > 105 && timer < 110)
        {
            dialogueIndex = 20;
        }
        else if (timer > 110 && timer < 115)
        {
            dialogueIndex = 21;
        }
        else if (timer > 115 && timer < 120)
        {
            dialogueIndex = 22;
        }
        else if (timer > 120 && timer < 125)
        {
            dialogueIndex = 23;
        }
        else if (timer > 125 && timer < 130)
        {
            dialogueIndex = 24;
        }
        else if (timer > 130 && timer < 135)
        {
            dialogueIndex = 25;
        }
        else if (timer > 135 && timer < 140)
        {
            dialogueIndex = 26;
        }
        else if (timer > 140 && timer < 145)
        {
            dialogueIndex = 27;
        }
        else if (timer > 145 && timer < 150)
        {
            dialogueIndex = 28;
        }
        else if (timer > 150 && timer < 155)
        {
            dialogueIndex = 29;
        }
        else if (timer > 155 && timer < 160)
        {
            dialogueIndex = 30;
        }
        else if (timer > 160 && timer < 165)
        {
            dialogueIndex = 31;
        }
        else if (timer > 165 && timer < 170)
        {
            dialogueIndex = 32;
        }
        else if (timer > 170 && timer < 175)
        {
            dialogueIndex = 33;
        }
        else if (timer > 175 && timer < 180)
        {
            dialogueIndex = 34;
            blackscreen.SetActive(true);
        }
        else if (timer > 180)
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
