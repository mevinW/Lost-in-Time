using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelScriptCrashSite : MonoBehaviour
{
    public GameObject guide;
    public GameObject leftButton;
    public GameObject rightButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.position.x > 0)
        {
            rightButton.SetActive(true);
        }
        else
        {
            if (guide.activeSelf)
            {
                leftButton.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        rightButton.SetActive(false);
        leftButton.SetActive(false);
    }
}
