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

    private IEnumerator scene2;
    private IEnumerator scene3;
    public int Ascended = 0;
    public int Descended = 0;

    public GameObject blackScreen;


    // Start is called before the first frame update
    void Start()
    {
        //currentTask = State.currentTask;
        scene2 = NextScene(2);
        scene3 = NextScene(3);
        manager = GameObject.FindWithTag("Manager");
        money = manager.GetComponent<MoneyScript>();
        uiManagerScript = manager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //KEEP TRACK OF STATS
       
        switch (currentTask)
        {
            case 0:
                //Send 3 souls to the afterlife
                Tasktext.text = "Welcome to the SPC, I will be your supervisor.  Your job will consist of sorting souls, but I also give extra tasks to my employees to encourage them to do an even better job.  Your first task is simply to sort a soul to ascend by pressing.[SPACE].";
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
                Tasktext.text = "I'm letting you know now, we will be carefully monitoring your decisions.  You can see how you are doing below your desk represented by a letter grade A-F! Now try sending 2 souls to ascend [SPACE]";
                // money.cashSign.gameObject.SetActive(true);
                // money.cashText.gameObject.SetActive(true);
                uiManagerScript.Grade.gameObject.SetActive(true);

                if (Ascended >= 1)
                {
                    Tasktext.text = "I'm letting you know now, we will be carefully monitoring your decisions.  You can see how you are doing below your desk represented by a letter grade A-F! Now try sending 1 souls to ascend [SPACE]";
                    if (Ascended >= 2)
                    {
                        money.Cash += 300;
                        currentTask = 3;
                        Reset();
                    }
                }
                break;
            case 3:
                Tasktext.text = "You can click on the computer to see more about the soul and view their profile!   Click the computer and then press [SPACE] or [DEL] to let me know you are ready to begin official business!";
                if(Ascended >= 1 || Descended >= 1)
                {
                    StartCoroutine(scene2);
                }
                //StartCoroutine(scene3);   
                break;
            case 4:
                Tasktext.text = "Now that it's night, you can click the computer to look at the shop or view your journal!  Press either [SPACE] or [DEL] to go to the next day.";
                if(Ascended > 0 || Descended > 0)
                {
                    currentTask = 5;
                    StartCoroutine(scene3);
                }
                
                break;
            case 5:
                Tasktext.text = "Now that you are ready for the job, it is time to get sorting!  Do your best, no pressure!";
                uiManagerScript.Grade.gameObject.SetActive(true);
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
        State.score = manager.GetComponent<ScoreManager>().score;
        Debug.Log(State.score);
        yield return new WaitForSeconds(3f);
        
        SceneManager.LoadScene(sceneIndex);
        StopCoroutine(scene2);
        StopCoroutine(scene3);
    }


}
