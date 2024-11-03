using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public string[] popUps;
    public Text popUpText;
    public GameObject player;

    private int popUpIndex = 0;
    private PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();

    }

    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (popUpIndex == i)
            {
                popUpText.text = popUps[i];
            }
        }
        if (popUpIndex == 0)
        {
            playerMovement.jumpSpeed = 0f;

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 1)
        {
            playerMovement.jumpSpeed = 8f;

            if (Input.GetKeyDown(KeyCode.W))
            {
                popUpIndex++;
                popUpText.text = "";
            }
        }
    }
}
