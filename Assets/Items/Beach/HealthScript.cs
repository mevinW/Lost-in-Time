using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public GameObject camera;
    public GameObject player;

    public Image healthBar;
    public float healthAmount = 100f;

    public GameObject airBar;

    public void takeDamage(float damage)
    {
        if (healthAmount >= 0 && damage > 0f)
        {
            healthAmount -= damage;
            healthBar.fillAmount = healthAmount / 100f;
        }
        else if (healthAmount <= 100 && damage < 0f)
        {
            healthAmount -= damage;
            healthBar.fillAmount = healthAmount / 100f;
        }

        if(healthAmount <= 0)
        {
            healthAmount = 100f;
            healthBar.fillAmount = healthAmount / 100f;
            airBar.GetComponent<AirScript>().airAmount = 100f;
            player.transform.position = new Vector3(-6.8f, 3.6f, 0f);
            camera.transform.position = new Vector3(0, 0, -10);
        }
    }
}
