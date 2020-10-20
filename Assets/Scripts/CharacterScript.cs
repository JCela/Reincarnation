using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This is the script holding information about the current Character.
public class CharacterScript : MonoBehaviour
{
    private IEnumerator initvars;
    

    //Variable initilization
    int LevelOfMoral;
    int LevelOfActualization;
    int LevelOfLoyalty;
    int LevelOfIntegrity;

    private int lastNumber = 0;

    void Start()
    {
        initvars = SetCharVariables();
        StartCoroutine(initvars);

    }
    void Update()
    {
        Random.seed = System.DateTime.Now.Millisecond;
    }
   

    private IEnumerator SetCharVariables()
    {
        
        LevelOfMoral = GetRandom(10, 20);
        yield return new WaitForSeconds(0.1f);
        LevelOfActualization = GetRandom(10, 20);
        yield return new WaitForSeconds(0.1f);
        LevelOfLoyalty = GetRandom(20, 30);
        yield return new WaitForSeconds(0.1f);
        LevelOfIntegrity = GetRandom(30, 40);
        yield return new WaitForSeconds(0.1f);

        Debug.Log("Moral level" + LevelOfMoral);
        Debug.Log("Actualization level" + LevelOfMoral);
        Debug.Log("Loyalty level" + LevelOfMoral);
        Debug.Log("Integrity level" + LevelOfMoral);
        StopCoroutine(initvars);
    }
    int GetRandom(int min, int max)
    {
        int rand = Random.Range(min, max);
        while (rand == lastNumber)
            rand = Random.Range(min, max);
        lastNumber = rand;
        return rand;
    }
}
