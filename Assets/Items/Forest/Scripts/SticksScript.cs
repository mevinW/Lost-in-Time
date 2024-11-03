using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SticksScript : MonoBehaviour
{
    public GameObject mark;
    public GameObject repairsBook;

    public void foundStick()
    {
        mark.SetActive(true);
        repairsBook.GetComponent<RepairMaterialsScript>().addStick();
    }
}
