using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideScript : MonoBehaviour
{
    public GameObject logic;
    public GameObject guide;
    public string[] advice;
    public Text adviceText;

    public void giveAdvice()
    {
        if (adviceText.text == advice[logic.GetComponent<LogicScript>().getScreen()])
        {
            adviceText.text = "";
        }
        else
        {
            adviceText.text = advice[logic.GetComponent<LogicScript>().getScreen()];
        } 
    }
}
