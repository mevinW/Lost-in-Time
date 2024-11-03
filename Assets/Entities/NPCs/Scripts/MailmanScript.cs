using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mailman : MonoBehaviour
{
    public Text interaction;
    public bool isClose;

    public GameObject dialoguePanel;
    public Text dialogueText;

    public string[] dialogueNotFound;
    public string[] dialogueFound;
    public string[] dialoguePackage;
    private int numDialogue = 0;

    private int index;
    public float wordSpeed;

    public GameObject contButton;

    public GameObject player;

    public GameObject package;
    public GameObject boulder;

    void Start()
    {

    }

    void Update()
    {
        if (numDialogue == 0)
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
        if (numDialogue == 1)
        {
            if (Input.GetKeyDown(KeyCode.T) && isClose && !dialoguePanel.activeSelf)
            {
                if(!package.activeSelf)
                {
                    numDialogue++;
                }
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
        if (numDialogue == 2)
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

            if (dialogueText.text == dialoguePackage[index])
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
        if (numDialogue == 0)
        {
            foreach (char letter in dialogueNotFound[index].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(wordSpeed);
            }
        }
        else if(numDialogue == 1)
        {
            foreach (char letter in dialogueFound[index].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(wordSpeed);
            }
        }
        else if (numDialogue == 2)
        {
            foreach (char letter in dialoguePackage[index].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(wordSpeed);
            }
        }
    }

    public void nextLine()
    {
        if (numDialogue == 0)
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
                package.SetActive(true);
                numDialogue++;
            }
        }
        else if (numDialogue == 1)
        {
            contButton.SetActive(false);
            if (index < dialogueFound.Length - 1)
            {
                index++;
                dialogueText.text = "";
                StartCoroutine(Typing());
            }
            else
            {
                zeroText();
                if(!package.activeSelf)
                {
                    numDialogue++;
                }
            }
        }
        else if (numDialogue == 2)
        {
            contButton.SetActive(false);
            if (index < dialoguePackage.Length - 1)
            {
                index++;
                dialogueText.text = "";
                StartCoroutine(Typing());
            }
            else
            {
                zeroText();
                gameObject.SetActive(false);
                boulder.SetActive(false);
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
