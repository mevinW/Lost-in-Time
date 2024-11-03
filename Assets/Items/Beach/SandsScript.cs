using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandsScript : MonoBehaviour
{
    public GameObject mark;
    public GameObject repairsBook;

    public int numSand = 0;

    public void foundSand()
    {
        mark.SetActive(true);
        numSand++;
        repairsBook.GetComponent<RepairMaterialsScript>().addSand();
    }
}
