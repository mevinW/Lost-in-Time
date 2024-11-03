using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabsScript : MonoBehaviour
{
    public GameObject mark;
    public GameObject birdNPC;
    public GameObject repairsBook;

    public int numCrabs = 0;

    public void foundCrab()
    {
        mark.SetActive(true);
        numCrabs++;
        if(numCrabs == 3)
        {
            birdNPC.GetComponent<BirdScript>().first = false;
        }
        repairsBook.GetComponent<RepairMaterialsScript>().addCrab();
    }
}
