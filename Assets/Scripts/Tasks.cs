using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tasks : MonoBehaviour
{
    public int currentTask = 0;
    private int lastNumber = 0;
    public Text Tasktext;
    private float Cash;
    private MoneyScript money;
    private GameObject manager;
    private UIManager uiManagerScript;
    private GameObject character;
    private IEnumerator scene2;
    private IEnumerator scene3;
    private IEnumerator scene4;
    public int Ascended = 0;
    public int Descended = 0;

    public GameObject blackScreen;


    // Start is called before the first frame update
    void Start()
    {
        if (State.currentTask > 4)
        {
            currentTask = State.currentTask;
        }
        scene2 = NextScene(2);
        scene3 = NextScene(1);
        scene4 = NextScene(3);
        manager = GameObject.FindWithTag("Manager");
        money = manager.GetComponent<MoneyScript>();
        uiManagerScript = manager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(State.isCashOn == true)
        {
            money.cashSign.gameObject.SetActive(true);
            money.cashText.gameObject.SetActive(true);
        }
        character = GameObject.FindWithTag("Character");
        //JContainer = GameObject.FindWithTag("Journal");
        //KEEP TRACK OF STATS


        switch (currentTask)
        {
            case 0:
                State.Day = 1;
                //Send 3 souls to the afterlife
                Tasktext.text = "Welcome to the SPC, I will be your supervisor.  Your job will consist of sorting souls, but I also give extra tasks to my employees.  Your first task is simply to sort a soul to ascend by pressing.[SPACE].";
                if(Ascended > 0)
                {
                    
                    currentTask = 1;
                    Reset();
                }
                else if(Descended > 0)
                {
                    currentTask = 1;
                    Reset();
                }
                break;
            case 1:
                Tasktext.text = "Not all souls are fit for the afterlife.  It can be difficult to force a soul into mortality again, but we must keep the afterlife only for those who deserve it. Now try descending a soul by pressing [DEL] .";
                if (Descended >= 1)
                {
                    Tasktext.text = "COMPLETE";
                    money.Cash += 300;
                    Debug.Log("Money:" + money.Cash);
                    currentTask = 2;
                    Reset();
                }
                break;
            case 2:
                Tasktext.text = "We will be watching your decisions.  Whether or not you sent the soul to the appropriate place will determine the grade seen on your desk! Now try sending 2 souls to ascend [SPACE]";
                // money.cashSign.gameObject.SetActive(true);
                // money.cashText.gameObject.SetActive(true);
                uiManagerScript.Grade.gameObject.SetActive(true);

                if (Ascended >= 1)
                {
                    Tasktext.text = "We will be watching your decisions.  Whether or not you sent the soul to the appropriate place will determine the grade seen on your desk! Now try sending 1 soul to ascend [SPACE]";
                    if (Ascended >= 2)
                    {
                        money.Cash += 300;
                        currentTask = 3;
                        Reset();
                    }
                }
                break;
            case 3:
                Tasktext.text = "You can click on the icons to see more about the soul!   Click the computer and click the buttons with notifications, then press [SPACE] or [DEL]";
                if(Ascended >= 1 || Descended >= 1)
                {
                    StartCoroutine(scene2);
                }
                //StartCoroutine(scene3);   
                break;
            case 4:
                State.Entry = 0;
                Tasktext.text = "Now that it's night, you can click the computer to look at the shop or view your journal!  Press either [SPACE] or [DEL] when ready to go to the next day.";
                if(Ascended > 0 || Descended > 0)
                {
                    State.currentTask = 5;
                    currentTask = 5;
                    State.Day = 2;
                    StartCoroutine(scene3);
                    Reset();
                }
                
                break;
            case 5:
                Tasktext.text = "Now that you are ready for the job, it is time to get sorting!  Do your best, no pressure!";
                uiManagerScript.Grade.gameObject.SetActive(true);
                if(Ascended > 2 || Descended > 2)
                {
                    currentTask = 6;
                    Reset();
                }
                break;
            case 6:
                Tasktext.text = "Hmmm you look suprised to see this one, hurry up and finish sorting before it gets dark!";
                character.GetComponent<SpriteRenderer>().color = Color.red;
                if (Ascended > 0 || Descended > 0)
                {
                    State.currentTask = 7;
                    currentTask = 7;
                    StartCoroutine(scene2);
                    Reset();
                }
                break;
            case 7:
                State.Entry = 1;
                Tasktext.text = "Don't stay up all night writing OK?  You've got a lot of sorting to do, plus tomorrow is pay day!";
                if (Ascended > 0 || Descended > 0)
                {
                    State.currentTask = 8;
                    currentTask = 8;
                    State.Day = 2;
                    StartCoroutine(scene3);
                    Reset();
                }
                break;
            case 8:
                Tasktext.text = "Today is a quick day!  Only one soul came through that needs to be sorted.";
                if (Ascended > 0 || Descended > 0)
                {
                    StartCoroutine(scene2);
                    State.currentTask = 9;
                    currentTask = 9;
                    Reset();
                }
                break;
            case 9:
                Tasktext.text = "I deposited some money into your computer, you should be able to buy some upgrades now to help you sort more efficiently! Also, I noticed you looking all glum earlier today, keep your head up!  This'll all be over soon.";
                State.cash =300;
                State.Entry = 2;
                State.isCashOn = true;
                if (Ascended > 0 || Descended > 0)
                {
                    State.currentTask = 10;
                    currentTask = 10;
                    StartCoroutine(scene3);
                    Reset();
                }   
                break;
            case 10:
                Tasktext.text = "Now Rhett, I know you would never hurt anyone NOW after dieing... right?";
                if(Ascended > 1 || Descended > 1)
                {
                    StartCoroutine(scene4);
                }
                break;


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

    public void GetNewTask()
    {
        //Reset
        Ascended = 0;
        Descended = 0;
        currentTask = GetRandom(3,5);

    }

    public void Reset()
    {
        Ascended = 0;
        Descended = 0;
    }

    private IEnumerator NextScene(int sceneIndex)
    {
        //blackScreen.SetActive(true);
        //yield return new WaitForSeconds(600000f*Time.deltaTime);
        //blackScreen.SetActive(true);
        State.score = manager.GetComponent<ScoreManager>().currentScore;
        Debug.Log(State.score);
        yield return new WaitForSeconds(3f);
        
        SceneManager.LoadScene(sceneIndex);
        StopCoroutine(scene2);
        StopCoroutine(scene3);
    }


}
