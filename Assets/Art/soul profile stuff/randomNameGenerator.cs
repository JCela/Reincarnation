using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomNameGenerator : MonoBehaviour
{
    string[] firstName ={ "Jay", "Jackson", "Lynn", "Mark", "Zehua", };
    string[] lastName = { "Maylol", "Coolie", "Whatt", "Wewe", "Wolly", };


    public string GetRandomName()
    {

        int firstNameIndex = Random.Range(0, firstName.Length);
        int lastNameIndex = Random.Range(0, lastName.Length);

        string characterName =

            firstName[firstNameIndex] +" "+
            lastName[lastNameIndex];

        return characterName;
    }






}
