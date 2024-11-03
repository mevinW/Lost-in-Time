using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScript : MonoBehaviour
{
    public GameObject logic;
    public GameObject canvas;

    void OnEnable()
    {
        logic.SetActive(true);
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
