using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixBridgeScript : MonoBehaviour
{
    private bool isFixed = false;
    public GameObject plank;
    public GameObject fixButton;

    public GameObject materials;
    private MaterialsScript materialsReference;

    void Start()
    {
        materialsReference = materials.GetComponent<MaterialsScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isFixed)
        {
            fixButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        fixButton.SetActive(false);
    }

    public void fix()
    {
        if(materialsReference.numWood >= 4)
        {
            materialsReference.numWood -= 4;
            materialsReference.woodCount.text = materialsReference.numWood.ToString();
            plank.SetActive(true);
            isFixed = true;
            fixButton.SetActive(false);
        }
    }
}
