using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsScript : MonoBehaviour
{
    public GameObject markRecipe;
    public GameObject markRepair;

    private bool isOpenRecipes = false;
    private bool isOpenRepairs = false;

    public GameObject recipesBook;
    public GameObject recipesPage;
    public GameObject repairsBook;
    public GameObject repairsPage;

    public GameObject player;
    public GameObject camera;

    private Vector3 currPos;

    void Start()
    {

    }

    public void openRecipes()
    {
        if (!repairsPage.activeSelf)
        {
            if (!isOpenRecipes)
            {
                currPos = camera.transform.position;
                player.GetComponent<PlayerMovement>().speed = 0f;
                camera.GetComponent<CameraFollowLab>().enabled = false;
                camera.transform.position = new Vector3(0, 0, -10);
                recipesPage.SetActive(true);
            }
            else
            {
                player.GetComponent<PlayerMovement>().speed = 5f;
                recipesPage.SetActive(false);
                markRecipe.SetActive(false);
                camera.GetComponent<CameraFollowLab>().enabled = true;
                camera.transform.position = currPos;
            }
            isOpenRecipes = !isOpenRecipes;
        }
    }
    public void openRepairs()
    {
        if (!recipesPage.activeSelf)
        {
            if (!isOpenRepairs)
            {
                currPos = camera.transform.position;
                player.GetComponent<PlayerMovement>().speed = 0f;
                camera.GetComponent<CameraFollowLab>().enabled = false;
                camera.transform.position = new Vector3(0, 0, -10);
                repairsPage.SetActive(true);
            }
            else
            {
                player.GetComponent<PlayerMovement>().speed = 5f;
                repairsPage.SetActive(false);
                markRepair.SetActive(false);
                camera.GetComponent<CameraFollowLab>().enabled = true;
                camera.transform.position = currPos;
            }
            isOpenRepairs = !isOpenRepairs;
        }
    }
}
