using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Ascended;
    public Text Reincarnated;
    public Text Grade;
    float totalAscended;
    float totalReincarnated;

    void Update()
    {
        Ascended.text = "" + totalAscended.ToString();
        Reincarnated.text = "" + totalReincarnated.ToString();
        
    }

    public void AddToAscended()
    {
        totalAscended++;
    }
    public void AddToReincarnated()
    {
        totalReincarnated++;
    }
}
