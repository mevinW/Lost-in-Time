using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreScript : MonoBehaviour
{
    public GameObject mark;

    private bool isClose = false;
    public GameObject core;
    public GameObject repairsBook;

    public int numCores = 0;

    public void foundCore()
    {
        if (isClose)
        {
            mark.SetActive(true);
            numCores++;
            repairsBook.GetComponent<RepairMaterialsScript>().addCore();
            core.SetActive(false);
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
