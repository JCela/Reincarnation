using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newAttributeTest : MonoBehaviour
{
    string[] positiveVirtue = { "Generous", "loyal", "Devoted", "loving",
                                "kind", "sincere", "peaceful", "patient" };
    string[] positiveFulfillment = {"I have a wonderful family","I have a great job","I work out everyday",
                                    "I wish people are safe everyday","I love street animals I see everyday"};
    string[] positiveGS = { "I help old lady", "I can eat 10 pizzas","I love to help people ", "I help people everyday"};

    string[] neutralVirtue = { "Impatient", "selfish", "narcissistic", "bossy", "ambitious", "obnoxious" };
    string[] neutralFulfillment = { "I just slacking and not doing anything","I am very lazy", "I am weak"};
    string[] neutralGS = { "I stay silent when I see things", "I dont care about anything", "I dont care about others"};
    
    string[] negativeVirtue = { "Malicious", "unmerciful", "evil", "cunning", "ugly" };
    string[] negativeFulfillment = {"I hate people", "I scold people everyday",
                                    "I wish everything disappear in front of my eyes" };
    string[] negativeGS = { "I kill people", "I murder things", "I kill animals"};

    string[] Virtue;
    string[] Fulfillment;
    string[] GS;


    


    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public string RandomCharacter()
    {
        //int pVIndex = Random.Range(0, positiveVirtue.Length);
        //int neuVIndex = Random.Range(0, neutralVirtue.Length);
        //int negVIndex = Random.Range(0, negativeVirtue.Length);

        //int pFIndex = Random.Range(0, positiveFulfillment.Length);
        //int neuFIndex = Random.Range(0, neutralFulfillment.Length);
        //int negFIndex = Random.Range(0, negativeFulfillment.Length);

        //int pGSIndex = Random.Range(0, positiveGS.Length);
        //int neuGSIndex = Random.Range(0, neutralGS.Length);
        //int negGSIndex = Random.Range(0, negativeGS.Length);


        int rand = Random.Range(0, 2);


        if (rand == 2)
        {
            Virtue = positiveVirtue;
            

            Fulfillment = positiveFulfillment;
            

            GS = positiveGS;
            

        }

        if (rand == 1)
        {
            Virtue = neutralVirtue;
            

            Fulfillment = neutralFulfillment;
           

            GS = neutralGS;
           
        }

        if (rand == 0)
        {
            Virtue = negativeVirtue;
           

            Fulfillment = negativeFulfillment;
            

            GS = negativeGS;
           
        }


        int VirtueIndex = Random.Range(0, Virtue.Length);
        int FulfillmentIndex = Random.Range(0, Fulfillment.Length);
        int GSIndex = Random.Range(0, GS.Length);

        


        string characterInfo =
            Virtue[VirtueIndex] + " "
            + Fulfillment[FulfillmentIndex] + " "
            + GS[GSIndex];

        return characterInfo;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
