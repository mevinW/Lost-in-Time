using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiftingScript : MonoBehaviour
{
    public GameObject mark;
    private bool inSpace = false;
    public GameObject sifterDone;
    public GameObject materials;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inSpace = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inSpace = false;
    }

    private void Update()
    {
        if (inSpace && sifterDone.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                player.GetComponent<Animator>().SetTrigger("ClickAD");
                float oreChance = 0.07f; // Change this value to adjust the probability

                // Generate a random number between 0 and 1
                float randomValue = Random.Range(0f, 1f);

                // Check if the random value is less than or equal to the ore chance
                if (randomValue <= oreChance)
                {
                    mark.SetActive(true);
                    // Increment the number of ores
                    materials.GetComponent<MaterialsScript>().addOre();
                }
            }
        }
    }
}
