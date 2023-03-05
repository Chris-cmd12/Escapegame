using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
    //liste des quete
    public bool hasKey = false;
    public bool hasManger = false;
    public bool hasDoucher = false;
    public bool hasBrosserDent = false;
    public bool hasLumiere = false;
    public bool hasSac = false;
    public bool hasReveil = false;
    //public bool doorOpen = false;

    public bool MissionCheck = false;

    private void Update()
    {
        if (hasKey == true && hasManger == true && hasDoucher == true && hasBrosserDent == true && hasLumiere == true && hasSac == true && hasReveil == true)
        {
            MissionCheck = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            hasKey = !hasKey;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            MissionCheck = !MissionCheck;
        }


    }

}
