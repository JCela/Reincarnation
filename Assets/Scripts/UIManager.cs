using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Ascended;
    public Text Reincarnated;
    float totalAscended = 0;
    float totalReincarnated = 0;

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
