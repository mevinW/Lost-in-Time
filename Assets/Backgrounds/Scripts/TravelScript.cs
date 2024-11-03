using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelScript : MonoBehaviour
{
    public GameObject leftButton;
    public GameObject rightButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.position.x > 0)
        {
            rightButton.SetActive(true);
        }
        else
        {
            leftButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        rightButton.SetActive(false);
        leftButton.SetActive(false);
    }
}
