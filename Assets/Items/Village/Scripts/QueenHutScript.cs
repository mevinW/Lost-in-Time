using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenHutScript : MonoBehaviour
{
    public GameObject eggs;
    public GameObject enterButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(eggs.GetComponent<EggsScript>().numEggs == 2)
        {
            enterButton.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        enterButton.SetActive(false);
    }
}
