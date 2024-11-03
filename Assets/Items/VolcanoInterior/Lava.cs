using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public GameObject camera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector3(-6f, -2.66f, 0);
            camera.transform.position = new Vector3(0, 0, -10);
        }
    }
}
