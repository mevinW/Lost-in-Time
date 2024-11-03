using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    public GameObject egg;
    public GameObject eggsScript;

    public void click()
    {
        eggsScript.GetComponent<EggsScript>().foundEgg();
        egg.SetActive(false);
    }
}
