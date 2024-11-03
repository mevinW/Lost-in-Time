using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReedScript : MonoBehaviour
{
    private bool isClose = false;

    public GameObject reed;
    public GameObject reedsScript;

    public void click()
    {
        if (isClose)
        {
            reedsScript.GetComponent<ReedsScript>().foundReed();
            reed.SetActive(false);
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
