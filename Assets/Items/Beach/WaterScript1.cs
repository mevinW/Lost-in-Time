using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    public GameObject player;
    public GameObject airBar;
    private AirScript airReference;

    void Start()
    {
        airReference = airBar.GetComponent<AirScript>();
    }

    private void FixedUpdate()
    {
        if(player.transform.position.y < 1.5)
        {
            airReference.takeDamage(0.3f);
        }
        else
        {
            airReference.takeDamage(-0.6f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerMovement.inWater = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerMovement.inWater = false;
        }
    }
}
