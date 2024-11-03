using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoPartScript : MonoBehaviour
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

    public GameObject recipesBook;

    public GameObject macheteDone;

    public GameObject materials;
    private MaterialsScript materialsReference;

    public GameObject repairs;
    private RepairMaterialsScript repairsReference;

    void Start()
    {
        materialsReference = materials.GetComponent<MaterialsScript>();
        repairsReference = repairs.GetComponent<RepairMaterialsScript>();
    }

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
                recipesBook.SetActive(true);
                macheteDone.SetActive(true);
                first = false;
            }
        }
        if (!first)
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
                materialsReference.addIron(materials.GetComponent<MaterialsScript>().numOres);
                repairsReference.addGlass(repairs.GetComponent<RepairMaterialsScript>().numSand);

                materialsReference.numOres = 0;
                repairsReference.numSand = 0;

                materialsReference.oreCount.text = "0";
                repairsReference.sandCount.text = "0";
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
