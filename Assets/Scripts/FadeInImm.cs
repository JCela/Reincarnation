using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInImm : MonoBehaviour
{
    public SpriteRenderer spriteToFade;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fadeOut(spriteToFade, 1f));
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            //Destroy(this.gameObject);
        }
    }

    

    IEnumerator fadeOut(SpriteRenderer MyRenderer, float duration)
    {
        float counter = 0;
        //Get current color
        Color spriteColor = MyRenderer.material.color;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(0, 1, counter / duration);
            Debug.Log(alpha);

            //Change alpha only
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            //Wait for a frame
            yield return null;
            
            
        }
    }



}
