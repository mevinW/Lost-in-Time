using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalsScript : MonoBehaviour
{
    public GameObject mark;
    public GameObject player;
    public GameObject repairsBook;

    public void foundCrystal()
    {
        mark.SetActive(true);
        player.GetComponent<Animator>().SetTrigger("ClickP");
        repairsBook.GetComponent<RepairMaterialsScript>().addCrystal();
    }
}
