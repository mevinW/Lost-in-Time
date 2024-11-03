using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelScriptForest : MonoBehaviour
{
    public GameObject nextButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nextButton.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        nextButton.SetActive(false);
    }
}
