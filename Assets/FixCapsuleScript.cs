using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCapsuleScript : MonoBehaviour
{
    public GameObject energyCore;
    public GameObject frame;
    public GameObject window;

    public GameObject fixButton;

    public GameObject logic;

    public void checkAll()
    {
        if(energyCore.activeSelf && frame.activeSelf && window.activeSelf)
        {
            fixButton.SetActive(true);
        }
    }

    public void fixCapsule()
    {
        logic.GetComponent<LogicScript>().switchEnd();
    }
}
