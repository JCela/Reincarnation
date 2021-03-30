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

    private IEnumerator scene3;
    public int Ascended = 0;
    public int Descended = 0;

    public GameObject blackScreen;


    // Start is called before the first frame update
    void Start()
    {
        scene3 = NextScene(2);
        
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
                    StartCoroutine(scene3);
                }
                //StartCoroutine(scene3);   
                break;
            case 4:
                Tasktext.text = "OK! It seems only right for your first official day of work you get a test!  This is Catrina, try to sort her correctly!";
                if(Ascended > 0)
                {
                    currentTask = 5;
                    money.Cash += 100;
                }else if(Descended > 0)
                {
                    currentTask = 6;
                }
                break;
            case 5:
                Tasktext.text = "I would agree with your decision, now try sorting through a couple people and i will see you in a bit!";
                break;
            case 6:
                Tasktext.text = "I have to tell you... if you send good people like that to reincarnate you won't make it very long here...  Try doing better with this next soul...";
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
        blackScreen.SetActive(true);
        yield return new WaitForSeconds(600000f*Time.deltaTime);
        //blackScreen.SetActive(true);
        yield return new WaitForSeconds(6f);
        
        SceneManager.LoadScene(sceneIndex);
        StopCoroutine(scene3);
    }


}
