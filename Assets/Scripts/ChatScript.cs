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
                        //Start Alruist convo
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hello.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Hello, what in your life made you an altruist?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "In grade school it would hurt me more to see my friends get bullied than me be bullied myself.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 3:
                                chatText.text = "I always felt their pain exponentially more than mine.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 4:
                                chatText.text = "Did putting others so far ahead of yourself detrement your own mental health?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 5:
                                chatText.text = "Yes, I often failed to see my own problems, and focused on other peoples problems more than my own.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 6:
                                chatText.text = "Interesting. Thank you for the extra information.";
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
                        //Criminal
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hey";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Says here you were a criminal. Care to explain?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "I knew this would come up. I had no choice.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 3:
                                chatText.text = "I had no family or support system, and had to rob stores and people to stay afloat.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 4:
                                chatText.text = "Did you really not have a choice? Couldn't you have found work?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 5:
                                chatText.text = "Found work? Where? Getting minimal pay doing menial labor?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 6:
                                chatText.text = "I got good enough at robbing that I almost started to make a life for myself.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 7:
                                chatText.text = "But what about the people that you robbed?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 8:
                                chatText.text = "I guess they were at the wrong place at the wrong time.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 9:
                                chatText.text = "I never hurt anyone, and even after doing it for so long, it pained me to take from others.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 10:
                                chatText.text = "Very well, I think I've heard enough about this. Thank you.";
                                //StartCoroutine(waitandspawnself);
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
                        //Traveler
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Woah this place is cool.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "So you were a traveler. Tell me about your travels";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "Ah yes. I am so glad I traveled enough to earn that tag. Traveling defined me. I had this urge to travel.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 3:
                                chatText.text = "I needed to see things and meet different people. I visited every continent on earth in my time, even Antartica.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 4:
                                chatText.text = "How did you make a living if you were always traveling?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 5:
                                chatText.text = "I had a YouTube channel where I documented my travels.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 6:
                                chatText.text = "It was very successful and provided for me even after I quit making videos.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 7:
                                chatText.text = "What a life you had. You should consider yourself lucky.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 8:
                                chatText.text = "Indeed I was.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 9:
                                chatText.text = "That's all for this section, thanks for chatting.";
                                //StartCoroutine(waitandspawnself);
                                break;
                        }
                        break;
                    case 1:
                        //Ceo
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hold on I can't connect to my email.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "Looks like you were a CEO! A successful life, I presume.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "You could say that. I founded a small business that brought virtual education to students who could not commute to school easily.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "Wow! That sounds like a great company to be CEO of.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "It was. I started the company when I was 26, and stuck with it until I retired at 62.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 5:
                                chatText.text = "It was rewarding to see my business boom to the size it did.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 6:
                                chatText.text = "An honorable company led by, from what I can tell, an honorable person.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 7:
                                chatText.text = "Thanks for the info here.";
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
                        //Graduate
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "I feel like im educated";
                                StartCoroutine(waitandspawnself);

                                break;
                            case 1:
                                chatText.text = "Yeah I would say so.";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Highschool was so easy.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "Oh okay";

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
                        //Couch potato
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Is there a place to sit here?";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "So you were a couch potato. What does that say about you?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "Yea I guess looking back I kind of was a bit of a couch potato.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 3:
                                chatText.text = "I was born well off and had funds for my whole life with minimal work.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "What a life, man.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 5:
                                chatText.text = "Did you do anything at all to better the world around you?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 6:
                                chatText.text = "I, uh... I guess I helped my mom bring the groceries in sometimes.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 7:
                                chatText.text = "Wow, what a hero you were. I bet those groceries were so heavy.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 8:
                                chatText.text = "Did you ever have a job, or a family?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 9:
                                chatText.text = "Nah, I kinda just stuck to myself and chilled my whole life.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 10:
                                chatText.text = "I kind of lived the dream to be honest.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 11:
                                chatText.text = "So no goals? No ambitions?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 12:
                                chatText.text = "My only goal was to chill. I met that goal.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 13:
                                chatText.text = "Well that sounds great. Thanks for the info, Mr. Potato.";
                                //StartCoroutine(waitandspawnself);
                                break;
                        }
                        break;
                    case 1:
                        //Cheater
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Hey there..";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "I'm told you were a cheater in life. What made you a cheater?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "I cheated on my wife.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 3:
                                chatText.text = "And how did that make you feel?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 4:
                                chatText.text = "In the moment, it was like I was blacked out. Things jut happened so quickly.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 5:
                                chatText.text = "Then, on my way home, these deep feelings of regret and pain hit me.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 6:
                                chatText.text = "I knew what I'd done was so horribly wrong.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 7:
                                chatText.text = "So you regret your actions?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 8:
                                chatText.text = "Tremendously. I ruined my kids lives by separating their parents, ";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 9:
                                chatText.text = "It still haunts me even in death.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 10:
                                chatText.text = "I understand. Thank you for talking about this.";
                                //StartCoroutine(waitandspawnself);
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
                                chatText.text = "We aren't allowed to smoke in here are we?  Not that I have one.";
                                StartCoroutine(waitandspawnsubject);

                                break;
                            case 2:
                                chatText.text = "Its all good.";
                                //StartCoroutine(waitandspawnself);

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
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "I don't like this game, its too hard.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 1:
                                chatText.text = "So you were a cheater? What type of cheating did you do?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 2:
                                chatText.text = "Ahahaha. I guess this is about my school days.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 3:
                                chatText.text = "You see, I was a bit of a serial cheater in school.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 4:
                                chatText.text = "Serial cheater? How so?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 5:
                                chatText.text = "It was almost a personal goal of mine to cheat as hard as I possibly could on anything.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 6:
                                chatText.text = "Tests, essays, you name it, I cheated!";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 7:
                                chatText.text = "Why did you cheat so hard?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 8:
                                chatText.text = "You know, that's a great question.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 9:
                                chatText.text = "I've never had to answer it because I never got caught.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 10:
                                chatText.text = "You must have had some talent.";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 11:
                                chatText.text = "Practice makes perfect.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 12:
                                chatText.text = "What about your adult life? Did the cheating continue into it?";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 13:
                                chatText.text = "Kind of. I guess I shifted from cheating to cutting corners. Still, I think I did ok. ";
                                StartCoroutine(waitandspawnsubject);
                                break;
                            case 14:
                                chatText.text = "I never cheated on anyone, just on assignments and stuff.";
                                StartCoroutine(waitandspawnself);
                                break;
                            case 15:
                                chatText.text = "Ok, I understand. Thanks for the info.";
                                //StartCoroutine(waitandspawnself);
                                break;

                        }
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
                        //Revolutionary option 1
                        switch (chatIndex)
                        {
                            case 0:
                                chatText.text = "Death to the oppressor!";
                                StartCoroutine(waitandspawnself);
                               
                                break;
                            case 1:
                                chatText.text = "What is that supposed to mean?";
                                StartCoroutine(waitandspawnsubject);
                                
                                break;
                            case 2:
                                chatText.text = "I don't know I saw a reddit post.";
                                //StartCoroutine(waitandspawnself);
                               
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
        subjectbubble.transform.localScale = new Vector3(0.05f, 0.03f, 1);
        ChatScript cs = subjectbubble.GetComponent<ChatScript>();
        cs.WriteBubble(x, y, m, i, l, a, chatInd);
    }

    public void NewSelfBubble()
    {
     
        GameObject selfbubble = (GameObject)Instantiate(selfPrefab, selfSpawn.transform.position, transform.rotation);
        selfbubble.transform.parent = overlay.transform;
        selfbubble.transform.localScale = new Vector3(0.05f, 0.03f, 1);
        ChatScript cs = selfbubble.GetComponent<ChatScript>();
        cs.WriteBubble(x, y, m, i, l, a, chatInd);
    }
}

