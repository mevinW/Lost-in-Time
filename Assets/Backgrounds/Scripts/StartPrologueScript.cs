using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPrologue : MonoBehaviour
{
    public GameObject prologue;

    public void startPrologue()
    {
        prologue.SetActive(true);
        gameObject.SetActive(false);
    }
}
