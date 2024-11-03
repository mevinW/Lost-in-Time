using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrologueScript : MonoBehaviour
{
    public GameObject logic;

    public GameObject sceneOne;
    public GameObject sceneTwo;
    public GameObject sceneThree;

    public float delayOne = 2f;
    public float delayTwo = 4f;
    public float delayThree = 6f;

    public float final = 8f;

    private float timer = 0f;

    void Start()
    {
        timer = 0f;
        logic.GetComponent<LogicScript>().PlayMusic(4);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer >= final)
        {
            sceneThree.SetActive(false);
            logic.GetComponent<LogicScript>().switchLab();
            gameObject.SetActive(false);
        }
        if (timer >= delayThree)
        {
            sceneTwo.SetActive(false);
            sceneThree.SetActive(true);
        }
        else if (timer >= delayTwo)
        {
            sceneOne.SetActive(false);
            sceneTwo.SetActive(true);
        }
        else if (timer >= delayOne)
        {
            sceneOne.SetActive(true);
        }
        timer += Time.deltaTime;
    }
}
