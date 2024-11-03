using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnePartScript : MonoBehaviour
{
    public Text interaction;
    public bool isClose;

    public GameObject dialoguePanel;
    public Text dialogueText;

    public string[] dialogue;

    private int index;
    public float wordSpeed;

    public GameObject contButton;

    public GameObject player;

    void Update()
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
        if (dialogueText.text == dialogue[index])
        {
            contButton.SetActive(true);
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
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void nextLine()
    {
        contButton.SetActive(false);
        if (index < dialogue.Length - 1)
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
