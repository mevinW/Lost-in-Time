using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeScript : MonoBehaviour
{
    public GameObject mark;
    public GameObject player;
    public GameObject materials;

    public GameObject axe;
    public Text chopText;

    private bool isClose = false;

    void Update()
    {
       if(isClose && Input.GetKeyDown(KeyCode.C)) {
            mark.SetActive(true);
            player.GetComponent<Animator>().SetTrigger("ClickC");
            materials.GetComponent<MaterialsScript>().addWood();
        } 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isClose = true;
        if(axe.activeSelf)
        {
            chopText.text = "Press c to chop";
        } 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isClose = false;
        chopText.text = "";
    }
}
