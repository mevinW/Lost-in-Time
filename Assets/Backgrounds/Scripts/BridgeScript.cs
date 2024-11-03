using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeScript : MonoBehaviour
{
    public GameObject logic;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.position.y < -5)
        {
            collision.transform.position = new Vector3(6.41f, -1.08f, 0f);
            logic.GetComponent<LogicScript>().switchBridge();
        }
    }
}
