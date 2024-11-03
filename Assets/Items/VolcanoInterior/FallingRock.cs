using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Rock") && !collision.CompareTag("Lava") && !collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else if(collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector3(-6f, -2.66f, 0);
            Destroy(gameObject);
        }
    }
}
