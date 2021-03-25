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
    }

    // Update is called once per frame
    void Update()
    {
        //KEEP TRACK OF STATS
       
        switch (currentTask)
        {
            case 0:
                //Send 3 souls to the afterlife
                Tasktext.text = "Welcome friend!  So glad that you decided to join our company.  Alright, now that you're all set up, lets see how well you handle the job. Try ascending or descending this ghost by pressing space/del.";
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
                Tasktext.text = "Great work! Wow you learn quick. Now try descending 2 souls! .";
                if (Descended >= 2)
                {
                    Tasktext.text = "COMPLETE";
                    money.Cash += 300;
                    Debug.Log("Money:" + money.Cash);
                    currentTask = 2;
                    Reset();
                }
                break;
            case 2:
                Tasktext.text = "You will earn money for each task you complete! Free money yay! Now try sending 3 souls to the afterlife.";
                money.cashSign.gameObject.SetActive(true);
                money.cashText.gameObject.SetActive(true);
                if (Ascended >= 3)
                {
                    Tasktext.text = "Wow thats great! By the way, you will be graded on your performance! If you get bored of randomly pressing buttons, maybe try to get to know the souls a bit by clicking on some of their attributes!";
                    money.Cash += 300;
                    currentTask = 3;
                    Reset();
                }
                break;
            case 3:
                Tasktext.text = "you can click on the computer to see the soul!  Once you get your money you can spend it on upgrades after your daily shift!  See you tomorrow!";
                StartCoroutine(scene3);
                break;
            case 4:
                Tasktext.text = "Welcome back! It seems you have a special guest today!";
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
                Tasktext.text = "I would agree with your decision";
                break;
            case 6:
                Tasktext.text = "I have to tell you... if you send good people like that to reincarnate you won't make a lot of money.";
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
