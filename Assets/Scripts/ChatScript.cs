using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatScript : MonoBehaviour
{
    private GameObject chatTextObject;
    public Text chatText;
    private IEnumerator waitabitandkill;
    public Rigidbody2D rb;
    private Vector2 thrust;
    
    void Awake()
    {
        waitabitandkill = WaitSeconds(4.0f);
        StartCoroutine(waitabitandkill);
        thrust = new Vector2(0, 40);
    }

    void Update()
    {
        chatTextObject = this.transform.GetChild(1).gameObject;
    }

    public void WriteBubble(int random, int randomText, int moral, int integrity, int loyalty, int actualization)
    {
        if (random == 0) // moral
        {
            if (moral >= 5)
            {
                switch (randomText)
                {
                    case 0:
                        //Set bubbles text to Altruist
                        chatText.text = "Yes indeed I am an altruist person";
                        break;
                    case 1:
                        //Generous
                        chatText.text = "One might consider me Generous";
                        break;
                    case 2:
                        //Foster Parent
                        chatText.text = "Yes we foster children";
                        break;
                    case 3:
                        //Conservationist
                        chatText.text = "I believe in saving the environment";
                        break;
                    case 4:
                        //Charity Worker
                        chatText.text = "I am a charity worker!";
                        break;
                    case 5:
                        //Volunteer
                        chatText.text = "I volunteer in my free time :)";
                        break;
                    case 6:
                        //Teacher
                        chatText.text = "I am a full time elementary school teacher";
                        break;
                    case 7:
                        //Donater
                        chatText.text = "I like to help those in need";
                        break;
                    case 8:
                        //Selfless
                        chatText.text = "I care more for others than myself";
                        break;
                    case 9:
                        //Altruist
                        chatText.text = "I'm not sure";
                        break;
                }
            }
            else
            {
                switch (randomText)
                {
                    case 0:
                        //Egoist
                        chatText.text = "I don't have an ego!";
                        break;
                    case 1:
                        //Criminal
                        chatText.text = "I think if it is easy to steal they deserved it.";
                        break;
                    case 2:
                        //Murderer
                        chatText.text = "Don't test me I will kill you.";
                        break;
                    case 3:
                        //Vandal
                        chatText.text = "Crazy :)";
                        break;
                    case 4:
                        //Litter bug
                        chatText.text = "Yeah I am messy from time to time but its only because I am busy";
                        break;
                    case 5:
                        //Doesn't Flush
                        chatText.text = "I forget!";
                        break;
                    case 6:
                        //Seat leaver upper
                        chatText.text = "I forget!";
                        break;
                    case 7:
                        //Gluton
                        chatText.text = "What can i say?  Food is good";
                        break;
                    case 8:
                        //Lustful
                        chatText.text = "Come here sexy";
                        break;
                    case 9:
                        //Cheater
                        chatText.text = "Anything to win.";
                        break;
                }
            }
        }
        else if (random == 1) // actualization
        {
            if (actualization >= 5)
            {
                switch (randomText)
                {
                    case 0:
                        //Traveler
                        chatText.text = "I have seen the world!";
                        break;
                    case 1:
                        //Ceo
                        chatText.text = "I own many businesses";
                        break;
                    case 2:
                        //Author
                        chatText.text = "You should read some of my books on the radical left!";
                        break;
                    case 3:
                        //Married
                        chatText.text = "Thank god thats over.";
                        break;
                    case 4:
                        //Parent
                        chatText.text = "I love my children more than life itself.";
                        break;
                    case 5:
                        //Educated
                        chatText.text = "I am an alumni of Princeton University";
                        break;
                    case 6:
                        //Graduate
                        chatText.text = "I have my PhD";
                        break;
                    case 7:
                        //Executive
                        chatText.text = "i'll have to pencil you in for a meeting";
                        break;
                    case 8:
                        //Retired
                        chatText.text = "I guess you could say this is the ultimate retirement!";
                        break;
                    case 9:
                        //Profitable
                        chatText.text = "Got any money?";
                        break;
                }
            }
            else
            {
                switch (randomText)
                {
                    case 0:
                        //Couch potato
                        chatText.text = "Just one more episode!";
                        break;
                    case 1:
                        //Cheater
                        chatText.text = "You don't understand what it means to win!";
                        break;
                    case 2:
                        //Single
                        chatText.text = "I don't need anyone else, I am an independant being.";
                        break;
                    case 3:
                        //Uneducated
                        chatText.text = "Edumawha?";
                        break;
                    case 4:
                        //Hacker
                        chatText.text = "I would change your password if I were you.";
                        break;
                    case 5:
                        //Stoner
                        chatText.text = "Got a lighter?";
                        break;
                    case 6:
                        //Scammer
                        chatText.text = "Hi!  This is Ernie from Ernie's furniture!  We are trying to reach you for a delivery but still need your social security number!";
                        break;
                    case 7:
                        //Lonely
                        chatText.text = "Get away from me!";
                        break;
                    case 8:
                        //Confused
                        chatText.text = "I don't even know whats happening.  Who are you?";
                        break;
                    case 9:
                        //Lost
                        chatText.text = "Where am i?";
                        break;
                }
            }

        }
        else if (random == 2) // loyalty
        {
            if (loyalty >= 5)
            {
                switch (randomText)
                {
                    case 0:
                        //Married once
                        chatText.text = "I used to be married yes.";
                        break;
                    case 1:
                        //Social Hub
                        chatText.text = "Come on over!";
                        break;
                    case 2:
                        //trustworthy
                        chatText.text = "You can put your trust in me.";
                        break;
                    case 3:
                        //Reliable
                        chatText.text = "I do believe I am someone you can depend everything on.";
                        break;
                    case 4:
                        //Best Friend
                        chatText.text = "BroOOO!";
                        break;
                    case 5:
                        //Bud
                        chatText.text = "Hey man! Long time no see.";
                        break;
                    case 6:
                        //Real One
                        chatText.text = "Hello, how are you?";
                        break;
                    case 7:
                        //FILLER
                        chatText.text = "FILLER";
                        break;
                    case 8:
                        //FILLER
                        chatText.text = "FILLER";
                        break;
                    case 9:
                        //FILLER
                        chatText.text = "FILLER";
                        break;
                }
            }
            else
            {
                switch(randomText)
                {
                    case 0:
                        //Married many times
                        chatText.text = "I think I'm falling for you.";
                    break;
                    case 1:
                        //Robber
                        chatText.text = "Give me your wallet!";
                    break;
                    case 2:
                        //Stealer
                        chatText.text = "Check your pockets!";
                    break;
                    case 3:
                        //Thief
                        chatText.text = "Corporate America doesn't deserve my money.";
                    break;
                    case 4:
                        //Cheater
                        chatText.text = "I paid them to take my exam.";
                    break;
                    case 5:
                        //Enemy
                        chatText.text = "You again?!";
                    break;
                    case 6:
                        //Stranger
                        chatText.text = "Who are you?";
                    break;
                    case 7:
                        //Unknown
                        chatText.text = "???";
                    break;
                    case 8:
                        //Beared
                        chatText.text = "Check this scruff!";
                    break;
                    case 9:
                        //Quiet
                        chatText.text = "...";
                    break;
                }
            }

        }
        else if (random == 3) // integrity
        {
            if (integrity >= 5)
            {


                switch (randomText)
                {
                    case 0:
                        //Strong
                        chatText.text = "Wanna arm wrestle?";
                        break;
                    case 1:
                        //Brave
                        chatText.text = "Charge forward into the next world!";
                        break;
                    case 2:
                        //Leader
                        chatText.text = "Follow me.  I will figure this one out.";
                        break;
                    case 3:
                        //Tough
                        chatText.text = "Hit me again!";
                        break;
                    case 4:
                        //Unkillable
                        chatText.text = "I never really died.";
                        break;
                    case 5:
                        //trustworthy
                        chatText.text = "You can put your trust in me.";
                        break;
                    case 6:
                        //Unchanging
                        chatText.text = "I haven't changed my mind since that day.";
                        break;
                    case 7:
                        //Unwavering
                        chatText.text = "I will never change!";
                        break;
                    case 8:
                        //Revolutionary
                        chatText.text = "Death to the oppressor!!";
                        break;
                    case 9:
                        //FPrideful
                        chatText.text = "I am proud of who I am";
                        break;
                }
            }
            else
            {
                switch (randomText)
                {
                    case 0:
                        //Team Flipper
                        chatText.text = "Whos team are you on?";
                        break;
                    case 1:
                        //Snitch
                        chatText.text = "I know who killed me.";
                        break;
                    case 2:
                        //Snake
                        chatText.text = "I'll eat you whole!";
                        break;
                    case 3:
                        //Rat
                        chatText.text = "Hahahaha mad cause bad!";
                        break;
                    case 4:
                        //Dishonest
                        chatText.text = "I am completely clean, you should swipe me to Ascend.";
                        break;
                    case 5:
                        //Self Consious
                        chatText.text = "I know you are probably confused, but you shouldn't send me back.";
                        break;
                    case 6:
                        //Nepotist
                        chatText.text = "Screw you";
                        break;
                    case 7:
                        //Unfair Boss
                        chatText.text = "Stupid little people don't know their place.";
                        break;
                    case 8:
                        //Propoganda Spreader
                        chatText.text = "Fake news!";
                        break;
                    case 9:
                        //Liar
                        chatText.text = "Believe me :) !";
                        break;
                }
            }
        }
   }

    private IEnumerator WaitSeconds(float waitTime)
    {
        yield return new WaitForSeconds(0.1f);
        PushUp();
        yield return new WaitForSeconds(waitTime);
        Destroy(this.gameObject);
        StopCoroutine(waitabitandkill);
    }

    public void PushUp()
    {
        rb.AddForce(thrust, ForceMode2D.Impulse);
    }
}

