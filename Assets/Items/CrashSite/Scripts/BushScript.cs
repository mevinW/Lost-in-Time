using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushScript : MonoBehaviour
{
    public GameObject player;
    public GameObject scissors;

    public GameObject bush;
    public GameObject bushButton;

    public void removeBush()
    {
        bushButton.SetActive(false);
        player.GetComponent<Animator>().SetTrigger("Click");
        bush.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(scissors.activeSelf && bush.activeSelf)
        {
            bushButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (scissors.activeSelf)
        {
            bushButton.SetActive(false);
        }
    }
}
