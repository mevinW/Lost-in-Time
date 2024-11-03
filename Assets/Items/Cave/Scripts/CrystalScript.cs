using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalScript : MonoBehaviour
{
    private bool isClose = false;

    public GameObject crystal;
    public GameObject crystalsScript;

    public GameObject pickaxe;

    public void click()
    {
        if (isClose && pickaxe.activeSelf)
        {
            crystalsScript.GetComponent<CrystalsScript>().foundCrystal();
            crystal.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isClose = false;
        }
    }
}
