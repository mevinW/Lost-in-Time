using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabScript : MonoBehaviour
{
    private bool isClose = false;

    public GameObject crab;
    public GameObject crabsScript;

    public void click()
    {
        if (isClose)
        {
            crabsScript.GetComponent<CrabsScript>().foundCrab();
            crab.SetActive(false);
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
