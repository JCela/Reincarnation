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

    public bool isNight;

    private IEnumerator killcoroutine;
    private IEnumerator addnewcharacter;
    private IEnumerator lerpPlayer;
    private IEnumerator throwup;
    public GameObject charPrefab;
    public int characterHeight = -2;

    private GameObject tag1;
    private GameObject tag2;
    private GameObject tag3;
    public int soulPoints;

    private float timeelapsed;
    private float lerpduration = 3;

    private TagScript tag1script;
    private TagScript tag2script;
    private TagScript tag3script;

    public Animator ScanAnimator;
    public Animator HoleAnimator;
    public Animator hookAnimator;
    private Animator playerAnimator;
    public Transform startMarker;
    public Transform endMarker;

    void Start()
    {
        thrust = new Vector2(1, 0);
        uiManagerScript = this.GetComponent<UIManager>();
    }
     
    void Update()
    {
        

        character = GameObject.FindWithTag("Character");
        tag1 = character.transform.GetChild(0).gameObject;
        tag2 = character.transform.GetChild(1).gameObject;
        tag3 = character.transform.GetChild(2).gameObject;

        tag1script = tag1.GetComponent<TagScript>();
        tag2script = tag2.GetComponent<TagScript>();
        tag3script = tag3.GetComponent<TagScript>();
        killcoroutine = PushAndKill(1.0f);
        addnewcharacter = AddNewChar(1.0f);
        
        throwup = PushUp(1.0f);
        character = GameObject.FindWithTag("Character");
        rb = character.GetComponent<Rigidbody2D>();

        

        soulPoints = tag1script.currentPoints + tag2script.currentPoints + tag3script.currentPoints;
        //Debug.Log("This souls value in points is: " + soulPoints);
        playerAnimator = character.GetComponent<Animator>();
    }

    public void SwipeCharacterRight()
    {
        //Debug.Log("Player has chosen to send character to Ascend.");
        //hookAnimator.SetTrigger("clawGrab");
        playerAnimator.SetTrigger("Ascended");
        taskScript.Ascended++;
        StartCoroutine(throwup);
        
    }

    public void SwipeCharacterLeft()
    {
        //Debug.Log("Player has chosen to send character to Reincarnate.");
        taskScript.Descended++;
        
        HoleAnimator.SetTrigger("isFaded");
        playerAnimator.SetTrigger("Faded");
        StartCoroutine(killcoroutine);
        StartCoroutine(addnewcharacter);
    }

    private IEnumerator PushUp(float waitTime)
    {
        hookAnimator.SetTrigger("clawGrab");
        yield return new WaitForSeconds(waitTime);
        hookAnimator.ResetTrigger("clawGrab");
        yield return new WaitForSeconds(1.0f);
        
        StartCoroutine(killcoroutine);
        StartCoroutine(addnewcharacter);
        StopCoroutine(throwup);
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
        //HoleAnimator.ResetTrigger("isFaded");
        Instantiate(charPrefab, new Vector3(-1, characterHeight, -1), Quaternion.identity);
        //StartCoroutine(lerpPlayer);
        yield return new WaitForSeconds(waitTime);
        HoleAnimator.ResetTrigger("isFaded");
        ScanAnimator.SetTrigger("newChar");
        StopCoroutine(addnewcharacter);
    }

   

}
