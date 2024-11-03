using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    public Text interaction;
    public bool isClose;

    public GameObject dialoguePanel;
    public Text dialogueText;

    public string[] dialogueNotFound;
    public string[] dialogueFound;
    public bool first = true;

    private int index;
    public float wordSpeed;

    public GameObject contButton;

    public GameObject player;

    public GameObject beachBird;
    public GameObject repairsBook;

    void Update()
    {
        if (first)
        {
            if (Input.GetKeyDown(KeyCode.T) && isClose && !dialoguePanel.activeSelf)
            {
                player.GetComponent<PlayerMovement>().speed = 0f;

                if (dialoguePanel.activeInHierarchy)
                {
                    zeroText();
                }
                else
                {
                    dialoguePanel.SetActive(true);
                    StartCoroutine(Typing());
                }
            }

            if (dialogueText.text == dialogueNotFound[index])
            {
                contButton.SetActive(true);
            }
        }
        if (!first)
        {
            if (Input.GetKeyDown(KeyCode.T) && isClose && !dialoguePanel.activeSelf)
            {
                player.GetComponent<PlayerMovement>().speed = 0f;

                if (dialoguePanel.activeInHierarchy)
                {
                    zeroText();
                }
                else
                {
                    dialoguePanel.SetActive(true);
                    StartCoroutine(Typing());
                }
            }

            if (dialogueText.text == dialogueFound[index])
            {
                contButton.SetActive(true);
            }
        }
    }

    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
        player.GetComponent<PlayerMovement>().speed = 4f;
    }

    IEnumerator Typing()
    {
        if (first)
        {
            foreach (char letter in dialogueNotFound[index].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(wordSpeed);
            }
        }
        else
        {
            foreach (char letter in dialogueFound[index].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(wordSpeed);
            }
        }
    }

    public void nextLine()
    {
        if (first)
        {
            contButton.SetActive(false);
            if (index < dialogueNotFound.Length - 1)
            {
                index++;
                dialogueText.text = "";
                StartCoroutine(Typing());
            }
            else
            {

                zeroText();
            }
        }
        if (!first)
        {
            contButton.SetActive(false);
            if (index < dialogueFound.Length - 1)
            {
                index++;
                Debug.Log(index);

                dialogueText.text = "";
                StartCoroutine(Typing());
            }
            else
            {
                Debug.Log(index);

                repairsBook.GetComponent<RepairMaterialsScript>().numCrabs -= 3;
                repairsBook.GetComponent<RepairMaterialsScript>().crabCount.text = repairsBook.GetComponent<RepairMaterialsScript>().numCrabs.ToString();
                beachBird.SetActive(true);

                zeroText();
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interaction.text = "Press T to interact!";
            isClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interaction.text = "";
        isClose = false;
        zeroText();
    }
}