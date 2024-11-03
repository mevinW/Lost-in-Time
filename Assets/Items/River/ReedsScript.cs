using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReedsScript : MonoBehaviour
{
    public GameObject mark;
    public GameObject recipesBook;
    public GameObject player;

    public void foundReed()
    {
        mark.SetActive(true);
        player.GetComponent<Animator>().SetTrigger("Click");
        recipesBook.GetComponent<MaterialsScript>().addReed();
    }
}
