using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickScript : MonoBehaviour
{
    private bool isClose = false;

    public GameObject stick;
    public GameObject sticksScript;

    public void click()
    {
        if (isClose)
        {
            sticksScript.GetComponent<SticksScript>().foundStick();
            stick.SetActive(false);
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
