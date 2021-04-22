using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public float stretchTimer;
    public Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stretchTimer += Time.deltaTime;

        if (stretchTimer > 20 && stretchTimer < 21.5)
        {
            playerAnimator.SetTrigger("needStretch");
        }
        if(stretchTimer > 21.5)
        {
            playerAnimator.SetBool("needStretch", false);
            stretchTimer = 0;
        }
    }
}
