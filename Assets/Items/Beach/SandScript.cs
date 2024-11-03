using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandScript : MonoBehaviour
{
    private bool isClose = false;

    public GameObject sand;
    public GameObject sandsScript;

    public void click()
    {
        if (isClose)
        {
            sandsScript.GetComponent<SandsScript>().foundSand();
            sand.SetActive(false);
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
