using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperScript : MonoBehaviour
{
    public GameObject paper;
    private bool isClose = false;

    public GameObject repairsBook;

    public void click()
    {
        if (isClose)
        {
            repairsBook.SetActive(true);
            paper.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
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
