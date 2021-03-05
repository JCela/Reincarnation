using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tasks : MonoBehaviour
{
    public int currentTask = 0;
    private int lastNumber = 0;
    public Text Tasktext;


    public int Ascended = 0;
    public int Descended = 0;


    // Start is called before the first frame update
    void Start()
    {
        currentTask = 0;
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
                }
                else if(Descended > 0)
                {
                    currentTask = 1;
                }
                break;
            case 1:
                Tasktext.text = "Great work! Wow you learn quick. Now try descending 2 souls! .";
                if (Descended >= 2)
                {
                    Tasktext.text = "COMPLETE";
                    currentTask = 2;
                }
                break;
            case 2:
                Tasktext.text = "You will earn money for each task you complete! Free money yay! Now try sending 3 souls to the afterlife.";
                if (Ascended >= 3)
                {
                    Tasktext.text = "Wow thats great! By the way, you will be graded on your performance! If you get bored of randomly pressing buttons, maybe try to get to know the souls a bit by clicking on some of their attributes!";
                    GetNewTask();
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

    void GetNewTask()
    {
        //Reset
        Ascended = 0;
        Descended = 0;
        currentTask = GetRandom(3,5);

    }



}
