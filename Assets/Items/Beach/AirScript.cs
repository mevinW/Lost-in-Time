using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirScript : MonoBehaviour
{
    public GameObject healthBar;
    private HealthScript healthReference;

    public Image airBar;
    public float airAmount = 100f;

    private void Start()
    {
        healthReference = healthBar.GetComponent<HealthScript>();
    }

    public void takeDamage(float damage)
    {
        if(airAmount <= 0)
        {
            healthReference.takeDamage(0.3f);   
        }

        if (airAmount >= 0 && damage > 0f)
        {
            airAmount -= damage;
            airBar.fillAmount = airAmount / 100f;
        }
        else if (airAmount <= 100 && damage < 0f)
        {
            airAmount -= damage;
            airBar.fillAmount = airAmount / 100f;
        }
    }
}
