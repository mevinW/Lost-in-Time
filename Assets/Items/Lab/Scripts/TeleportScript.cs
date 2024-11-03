using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public GameObject teleportButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            teleportButton.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        teleportButton.SetActive(false);
    }
}
