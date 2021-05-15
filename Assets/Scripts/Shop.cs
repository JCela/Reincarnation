using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private GameObject jText;
    private GameObject UpText;
    private GameObject UIContainer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UIContainer = GameObject.FindWithTag("JournalText");
        jText = UIContainer.transform.GetChild(0).gameObject;
        UpText = jText.transform.GetChild(2).gameObject;
    }

    public void OnMouseDown()
    {
        if(State.cash >= 300)
        {
            State.cash = 0;
            State.boughtThird = true;
            Destroy(this.gameObject);
            Destroy(UpText);
        }

    }
}
