using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    float currentRound;
    public float currentScore;
    public float score;

    //private State state;
    private UIManager uiManagerScript;
    private GameObject character;
    private CharacterScript charscript;
    private string grade = "A";

    private int totalValue;

    private int m;
    private int a;
    private int i;
    private int l;

    void Start()
    {
        //currentScore = State.score/100;
        //currentRound = 1;  //BROKEN, NEEDS FIX
    }
    // Update is called once per frame
    void Update()
    {
        currentScore = State.score;
        currentRound = State.round;
        //State.score = score;
        character = GameObject.FindWithTag("Character");
        charscript = character.GetComponent<CharacterScript>();
        uiManagerScript = this.GetComponent<UIManager>();

        m = charscript.LevelOfMoral;
        a = charscript.LevelOfActualization;
        i = charscript.LevelOfIntegrity;
        l = charscript.LevelOfLoyalty;

        totalValue = m + a + i + l;

        score = (currentScore / currentRound)*100;
        Debug.Log("Score" + score);


        if(score >= 90)
        {
            grade = "A+";
        }
        else if(score >= 80)
        {
            grade = "A";
        }
        else if(score >= 70)
        {
            grade = "A-";
        }
        else if(score >= 60)
        {
            grade = "B+";
        }
        else if (score >= 50)
        {
            grade = "B";
        }
        else if (score >= 40)
        {
            grade = "B-";
        }
        else if (score >= 30)
        {
            grade = "C+";
        }
        else if (score >= 20)
        {
            grade = "C";
        }
        else if (score >= 10)
        {
            grade = "C-";
        }
        else if (score >= 0)
        {
            grade = "D+";
        }
        

        if (currentRound >= 5)
        {
            uiManagerScript.Grade.text = grade;
        }else if(currentRound >= 9)
        {
            //uiManagerScript.Grade.text = "Grade" + grade;
        }

    }

    public void AddA()//Ascended
    {
        currentRound+= 1f;
        State.round = currentRound;
        if(totalValue >= 20)
        {
            currentScore+=1f;
            State.score = currentScore;
        }
        
        
    }

    public void AddB()//Descended
    {
        currentRound+= 1f;
        State.round = currentRound;
        if (totalValue <= 20)
        {
            currentScore+=1f;
            State.score = currentScore;
        }
    }
}
