using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rock") || collision.gameObject.CompareTag("Lava"))
        {
            transform.position = new Vector3(-6f, -2.66f, 0);
        }
    }
}
