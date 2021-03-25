using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int currentRound;
    float currentScore;
    float score;


    private UIManager uiManagerScript;
    private GameObject character;
    private CharacterScript charscript;
    private string grade = "A";

    private int totalValue;

    private int m;
    private int a;
    private int i;
    private int l;

    // Update is called once per frame
    void Update()
    {
        character = GameObject.FindWithTag("Character");
        charscript = character.GetComponent<CharacterScript>();
        uiManagerScript = this.GetComponent<UIManager>();

        m = charscript.LevelOfMoral;
        a = charscript.LevelOfActualization;
        i = charscript.LevelOfIntegrity;
        l = charscript.LevelOfLoyalty;

        totalValue = m + a + i + l;

        //Debug.Log("Current Score" + (currentScore / currentRound)*100 + "%");
        score = (currentScore / currentRound) * 100;


        if(score >= 97)
        {
            grade = "A+";
        }
        else if(score >= 93)
        {
            grade = "A";
        }
        else if(score >= 90)
        {
            grade = "A-";
        }
        else if(score >= 87)
        {
            grade = "B+";
        }
        else if (score >= 83)
        {
            grade = "B";
        }
        else if (score >= 80)
        {
            grade = "B-";
        }
        else if (score >= 77)
        {
            grade = "C+";
        }
        else if (score >= 73)
        {
            grade = "C";
        }
        else if (score >= 70)
        {
            grade = "C-";
        }
        else if (score >= 67)
        {
            grade = "D+";
        }
        else if (score >= 63)
        {
            grade = "D";
        }
        else if (score >= 60)
        {
            grade = "D-";
        }
        else
        {
            grade = "F";
        }

        if (currentRound >= 5)
        {
            uiManagerScript.Grade.text = grade;
        }else if(currentRound >= 9)
        {
            uiManagerScript.Grade.text = "Grade" + grade;
        }

    }

    public void AddA()//Ascended
    {
        currentRound++;
        if(totalValue >= 20)
        {
            currentScore++;
        }
        
        
    }

    public void AddB()//Descended
    {
        currentRound++;
        if (totalValue <= 20)
        {
            currentScore++;
        }
    }
}
