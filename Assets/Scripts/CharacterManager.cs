using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private UIManager uiManagerScript;
    private GameObject character;
    private Rigidbody2D rb;
    private Vector2 thrust;
    public Tasks taskScript;
    

    private IEnumerator killcoroutine;
    private IEnumerator addnewcharacter;
    public GameObject charPrefab;
    public int characterHeight = 1;


    void Start()
    {
        thrust = new Vector2(40, 0);
        uiManagerScript = this.GetComponent<UIManager>();
       
    }
     
    void Update()
    {
        killcoroutine = PushAndKill(1.0f);
        addnewcharacter = AddNewChar(1.0f);
        character = GameObject.FindWithTag("Character");
        rb = character.GetComponent<Rigidbody2D>();
    }

    public void SwipeCharacterRight()
    {
        Debug.Log("Player has chosen to send character to Ascend.");
        taskScript.Ascended++;
        //rb.AddForce(thrust, ForceMode2D.Impulse);
        StartCoroutine(killcoroutine);
        StartCoroutine(addnewcharacter);
    }

    public void SwipeCharacterLeft()
    {
        Debug.Log("Player has chosen to send character to Reincarnate.");
        taskScript.Descended++;
        //rb.AddForce(-thrust, ForceMode2D.Impulse);
        StartCoroutine(killcoroutine);
        StartCoroutine(addnewcharacter);
    }

    private IEnumerator PushAndKill(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //Kill current character
        Destroy(character);
        StopCoroutine(killcoroutine);
    }

    private IEnumerator AddNewChar(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //Add a new character
        Instantiate(charPrefab, new Vector3(-1, characterHeight, -1), Quaternion.identity);
        StopCoroutine(addnewcharacter);
    }

}
