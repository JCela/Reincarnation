using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the script holding information about the current Character.
public class CharacterScript : MonoBehaviour
{
    private IEnumerator initvars;

    //Variable initilization
    public int LevelOfMoral;
    public int LevelOfActualization;
    public int LevelOfLoyalty;
    public int LevelOfIntegrity;
    

    //public Sprite[] characterSprite;

    private int lastNumber = 0;

    void Start()
    {
        //int spriteRandomizer = Random.Range(1, 10);
        initvars = SetCharVariables();
        StartCoroutine(initvars);
        //this.GetComponent<SpriteRenderer>().sprite = characterSprite[spriteRandomizer];
        
        
    }
    void Update()
    {
        Random.seed = System.DateTime.Now.Millisecond;
    }
   

    private IEnumerator SetCharVariables()
    {
        
        LevelOfMoral = GetRandom(0, 10);
        yield return new WaitForSeconds(0.1f);
        LevelOfActualization = GetRandom(0,10);
        yield return new WaitForSeconds(0.1f);
        LevelOfLoyalty = GetRandom(0,10);
        yield return new WaitForSeconds(0.1f);
        LevelOfIntegrity = GetRandom(0,10);
        yield return new WaitForSeconds(0.1f);

        Debug.Log("Moral level" + LevelOfMoral);
        //Debug.Log("Actualization level" + LevelOfActualization);
        //Debug.Log("Loyalty level" + LevelOfLoyalty);
        //Debug.Log("Integrity level" + LevelOfIntegrity);


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
