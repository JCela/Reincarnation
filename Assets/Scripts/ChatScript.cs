using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatScript : MonoBehaviour
{
    private GameObject chatTextObject;
    public Text chatText;
    private IEnumerator waitabitandkill;
    public IEnumerator waitandspawnself;
    public IEnumerator waitandspawnsubject;
    public Rigidbody2D rb;
    private Vector2 thrust;
    public int m;
    public int i;
    public int l;
    public int a;
    public int chatInd;
    public int x;
    public int y;

    public GameObject chatPrefab;
    public GameObject selfPrefab;
    private GameObject chatSpawn;
    private GameObject selfSpawn;
    private GameObject overlay;

    void Awake()
    {
        waitabitandkill = WaitSeconds(4.0f);
        StartCoroutine(waitabitandkill);
        waitandspawnself = NewSelfCo(3.3f);
        waitandspawnsubject = NewSubjectCo(3.3f);
        thrust = new Vector2(0, 40);
        overlay = GameObject.FindWithTag("Overlay");
        chatSpawn = overlay.transform.GetChild(0).gameObject;
        selfSpawn = overlay.transform.GetChild(1).gameObject;
    }

    void Update()
    {
        chatTextObject = this.transform.GetChild(1).gameObject;
    }

    public void WriteBubble(int random, int randomText, int moral, int integrity, int loyalty, int actualization, int chatIndex)
    {
        m = moral;
        i = integrity;
        l = loyalty;
        a = actualization;
        x = random;
        y = randomText;
        chatInd = chatIndex;
       
        if (random == 0) // moral
        {
            if (moral >= 5)
            {
                switch (randomText)
                {
                    case 0:
                        //Start Inventor convo
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hello.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "So you were an inventor? What type of stuff did you invent?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "I invented a backscratcher";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "How inventive! Invent anything else?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "Nope.";
                                //StartCoroutine(waitandspawnsubject);
                                break;
                            

                        }
                        break;
                    case 1:
                        //Generous convo
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hello there fine sir.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "So its says here you were generous in life, care to elaborate? ";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "Yes, of course. I was quite successful monetarily in life, so I had plenty of money to give away.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 3:
                                chatText.text = " I decided to start a food bank in my home town and donated millions to cancer research throughout my time on earth.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 4:
                                chatText.text = "Wow. The world needs more wealthy people like you. How did donating all that money feel?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 5:
                                chatText.text = "Obviously it felt good, but I didn't donate it for how it made me feel. I donated it to help others.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 6:
                                chatText.text = "Thank you for elaborating on this.";
                                break;

                        }
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
                        //Thief
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hey";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "It says here you were a thief.  What type of thief were you?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "I stole from other thiefs.  I considered myself somewhat of a vigilante.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "So you only stole from others who stole?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "Exactly. I never stole from people who were innocent.";
                                //StartCoroutine(waitandspawnsubject);
                                break;
                            
                        }
                        break;
                    case 2:
                        //Murderer
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hey :)";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Well, you probably saw this coming, but... it says you were a murderer.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "Yes. It was who I was.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "What do you mean it was who you were? Murdering defined you?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "It did. I had this.. urge. An itch that needed to be scratched... consistently";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 5:
                                chatText.text = "So you were a serial killer?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 6:
                                chatText.text = "Yes. I collected a single strand of hair from my victims as a trophy.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 7:
                                chatText.text = "Do you regret any of your kills?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 8:
                                chatText.text = "Do you regret when you scratch an itch on your arm?";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 9:
                                chatText.text = "Understood... well, I've heard enough about your... urges. Thank you.";
                                break;
                         
                        }
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
                        //Dad
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Woah this place is cool.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Looks like being a father was a large part of your life.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "It was. I had 3 sons, two of which I coached into pro baseball.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "What about the third one?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "Never really liked him to be honest.";
                                //StartCoroutine(waitandspawnsubject);
                                break;
                            
                        }
                        break;
                    case 1:
                        //Salesman
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hold on I can't connect to my email.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "So, you were a salesman? What goods did you sell?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "I sold knives to my close friends and family, and got a cut based on how many sales people I referred made!";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "Like a pyramid scheme?";
                                //StartCoroutine(waitandspawnsubject);
                                break;
                            
                        }
                        break;
                    case 2:
                        //Author
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "You should read my books on the economy";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "I bought a stock one time.";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Nice man.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "The company went bankrupt :(";
                                break;
                        }
                        break;
                    case 3:
                        //Married
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hey there ;)";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "Aren't you married?";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Yeah but what does that matter";
                                //StartCoroutine(waitandspawnself);

                                break;
                        }
                        break;
                    case 4:
                        //Parent
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "I love my children more than life itself.";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "Aw thats sweet, what are their names?";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Donald";
                                //StartCoroutine(waitandspawnself);

                                break;
                        }
                        break;
                    case 5:
                        //Educated
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "I feel like im educated";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "Nah ur supa dum, your just like ya motha";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "I need to cut you off.";
                                //StartCoroutine(waitandspawnself);

                                break;
                        }
                        break;
                    case 6:
                        //Lawyer
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Is this legal?";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "My files say that you were a lawyer. Can you give me some specifics?.";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Sure, I was a personal injury lawyer!  I’m the guy who makes YOU money if there’s no wet floor sign!";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "I see. Was this the only line of work you did?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "Sure was! Even made enough to get my face up on a couple billboards too";
                                break;
                        }
                        break;
                    case 7:
                        //Executive
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "I guess my stockholders wouldn't mind my passing would they?";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "Yeah I would say so.";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Aw shit.  Well hows the Nasdaq doing?";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "It crashed.";

                                break;
                        }
                        break;
                    case 8:
                        //Retired
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "I can't wait to see my partner again.";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "You will one day, I promise";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Thank you, I appreciate that. ";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "No problem :)";

                                break;
                        }
                        break;
                    case 9:
                        //Profitable
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Now how can we monetize this?";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "In game purchases!";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "I like the way you are thinking";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "That was a joke.";

                                break;
                        }
                        break;
                }
            }
            else
            {
                switch (randomText)
                {
                    case 0:
                        //Lawyer
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Is there a place to sit here?";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Looks like we have a lawyer here. Can you tell me what types of cases you worked with?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "I was a traffic ticket lawyer.  My job was to help my clients lower their fines on traffic violations";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "So you made people pay less for speeding tickets and such?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "Exactly. I was a bit of a hero if I do say so myself.";
                                //StartCoroutine(waitandspawnself);
                                break;
                           
                        }
                        break;
                    case 1:
                        //Magician
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Wanna see a trick?";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "A magician! How cool.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "Without my deck of cards I am nothing.  I feel naked.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "I am so sorry but the SPC can not provide cards to magicians due to company policy. ";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "That’s ok, I made enough people happy with my tricks during my life.  I am satisfied.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            
                            
                        }
                        break;
                    case 2:
                        //Single
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "i'm so lonely its crippling";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "You never found the one you loved?";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "I did, but I hope to be with her again soon.";
                                //StartCoroutine(waitandspawnself);

                                break;
                        }
                        break;
                    case 3:
                        //Uneducated
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Edumawa?";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "Sorry, I didn't mean for that to sound the wrong way...";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "I love Quiz night";
                                //StartCoroutine(waitandspawnself);

                                break;
                        }
                        break;
                    case 4:
                        //Hacker
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "You better change your password";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "What is that supposed to mean";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "You know exactly what is means.";
                                //StartCoroutine(waitandspawnself);

                                break;
                        }
                        break;
                    case 5:
                        //Stoner
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "You got a lighter friend?";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "Wow, so you smoked so much weed that ⅓ of your entire profile is dedicated to being a stoner.";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Oh dang that’s crazy.";
                                StartCoroutine(waitandspawnself);
                                break;

                        }
                        break;
                    case 6:
                        //Scammer
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Im gonna need ur credit card number";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "YWhat why?";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Ascent Fee";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "Who said i was ascending you?";

                                break;
                        }
                        break;
                    case 7:
                        //Lonely
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "I hate everyone!";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "What did I do?";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "You didn't do anything... but its just everyone else!";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "You seem hurt";

                                break;
                        }
                        break;
                    case 8:
                        //Confused
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "What is going on?";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "I'm just as confused as you bro";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Where's mom?";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "Well damn I don't know what to say.";

                                break;
                        }
                        break;
                    case 9:
                        //Lost
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Do you know where the Statue of Liberty is?";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "Its no where near here.";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Can you take a picture of me with the Statue of Liberty?";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "Gonna be hard.";

                                break;
                        }
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
                        //Gamer
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "This game is easy!";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Hello gamer. What games did you play?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "I was a pro Call of Duty player when I was young. You don’t keep reflexes like that forever, so my career didn’t last too long.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "Were you successful?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "I got 13 viewers on twitch once, so yea I’d consider myself a bit of a household name in gaming";
                                //StartCoroutine(waitandspawnsubject);
                                break;


                        }
                        break;
                    case 8:
                        //Mother
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hey hun.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Always good to see someone who was such a good mother it became one of their tags";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "Wow, that is great news! I loved my kids with all my heart, and gave them the world. ";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "How nice. Your kids must have loved you dearly.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "They did, I got so lucky with them! ";
                                //StartCoroutine(waitandspawnsubject);
                                break;


                        }
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
                        //Cult Leader
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "I don't like this game, its too hard.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Now I don’t see this every day… a cult leader! What cult did you lead?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "I led the knights of the sacred tomb";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "And what type of cult activities did the knights of the sacred tomb participate in?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "We worshipped the sacred tomb for 12 hours per day.  ";
                                //StartCoroutine(waitandspawnsubject);
                                break;
                            

                        }
                        break;
                    case 5:
                        //CEO
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "I'm the boss.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Looks like we got a CEO here. What company did you work for?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "I worked for a company that delivered empty boxes to warehouses.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "Empty boxes? Who needs those?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "Great question. All I knew was that I got paid millions and the workers made minimum wage!";
                                //StartCoroutine(waitandspawnsubject);
                                break;


                        }
                        break;
                    case 6:
                        //Angry
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = ">:(";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "I’m sorry to ask, but when an entire tag is “angry,” I have to know more.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "I JUST WANT TO BE ALIVE AGAIN. WHY DID I DIE. SO STUPID.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "Ok, the tag system definitely still works. Anything else you care to share?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "THIS PLACE IS SO GLOOMY. ADD SOME DAMN COLOR.";
                                //StartCoroutine(waitandspawnsubject);
                                break;


                        }
                        break;
                    case 7:
                        //Unknown
                        chatText.text = "???";
                    break;
                    case 8:
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "What should I draw?";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Looks like we have a creative soul here. What type of art did you make?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "All types of art.  It was my language.  What I couldn’t communicate with words, I communicated with my art.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "What was your favorite piece?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "I didn’t have a favorite. They all spoke to me in different, unique ways and I can’t pick one.";
                                //StartCoroutine(waitandspawnsubject);
                                break;


                        }
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
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hello, do you need help?";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "So you lived a life of giving. Can you give me some details?";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = " Of course. I was very fortunate to start a company and get lots of money at a young age.";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 3:
                                chatText.text = "So instead of keeping money you didn’t need you gave it away?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "Exactly. I didn’t need yachts or private jets, I just needed my family, and money can’t buy that.";
                                break;
                        }
                        break;
                    case 8:
                        //Teacher
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Did you do your hw?";
                                StartCoroutine(waitandspawnself);
                               
                                break;
                            case 1:
                                chatText.text = "Lovely to see an educator coming through. How was your teaching career?";
                                StartCoroutine(waitandspawnsubject);
                                
                                break;
                            case 2:
                                chatText.text = "It was lovely.  Ever since I was a child, I knew it was my destiny to teach.";
                                StartCoroutine(waitandspawnself);
                               
                                break;
                            case 3:
                                chatText.text = "What type of teaching did you do?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "I taught elementary school. I believed that if I could shape the youth, the world could be a better place.";
                                break;
                        }
                        //Revolutionary option 2
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
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Did you do your hw?";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "Hello! It says here you were a teacher. Care to elaborate?";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "I was a teacher.  It was the first job I got out of college and I rode it out my entire career..";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 3:
                                chatText.text = "So you spent your entire career as a teacher?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "Yes. I always wanted to do something else, but watching kids suffer through weekend homework never got old.";
                                break;
                        }
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

    public IEnumerator NewSubjectCo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        chatInd++;
        NewSubjectBubble();
        StopCoroutine(waitandspawnsubject);
    }

    public IEnumerator NewSelfCo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        chatInd++;
        NewSelfBubble();
        StopCoroutine(waitandspawnself);
    }

    public void PushUp()
    {
        //rb.AddForce(thrust, ForceMode2D.Impulse);
    }

    public void NewSubjectBubble()
    {
 
        GameObject subjectbubble = (GameObject)Instantiate(chatPrefab, chatSpawn.transform.position, transform.rotation);
        subjectbubble.transform.parent = overlay.transform;
        subjectbubble.transform.localScale = new Vector3(0.035f, 0.02f, 1);
        ChatScript cs = subjectbubble.GetComponent<ChatScript>();
        cs.WriteBubble(x, y, m, i, l, a, chatInd);
    }

    public void NewSelfBubble()
    {
     
        GameObject selfbubble = (GameObject)Instantiate(selfPrefab, selfSpawn.transform.position, transform.rotation);
        selfbubble.transform.parent = overlay.transform;
        selfbubble.transform.localScale = new Vector3(0.035f, 0.02f, 1);
        ChatScript cs = selfbubble.GetComponent<ChatScript>();
        cs.WriteBubble(x, y, m, i, l, a, chatInd);
    }
}

