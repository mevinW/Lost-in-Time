using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialsScript : MonoBehaviour
{
    public Text reedCount;
    public GameObject reedButton;
    public GameObject done;
    public int numReeds = 0;

    public Text oreCount;
    public int numOres = 0;

    public Text woodCount;
    public int numWood = 0;

    public Text ironCountAxe;
    public Text ironCountPickaxe;
    public GameObject axeButton;
    public GameObject pickaxeButton;
    public GameObject doneAxe;
    public GameObject donePickaxe;
    public int numIron = 0;

    public void addReed()
    {
        numReeds++;
        if(numReeds == 3)
        {
            reedButton.SetActive(true);
        }
        reedCount.text = numReeds.ToString() + "/3";
    }

    public void addOre()
    {
        numOres++;
        oreCount.text = numOres.ToString();
    }

    public void addWood()
    {
        numWood++;
        woodCount.text = numWood.ToString();
    }

    public void addIron(int num)
    {
        numIron += num;
        if (numIron >= 3)
        {
            axeButton.SetActive(true);
            pickaxeButton.SetActive(true);
        }
        if (!doneAxe.activeSelf)
        {
            ironCountAxe.text = numIron.ToString() + "/3";
        }
        if (!donePickaxe.activeSelf)
        {
            ironCountPickaxe.text = numIron.ToString() + "/3";
        }
    }

    public void craftAxe()
    {
        numIron -= 3;
        ironCountAxe.text = "";
        if (!donePickaxe.activeSelf)
        {
            ironCountPickaxe.text = numIron.ToString();
        }
        axeButton.SetActive(false);
        doneAxe.SetActive(true);
        if(numIron < 3)
        {
            pickaxeButton.SetActive(false);
        }
    }

    public void craftPickaxe()
    {
        numIron -= 3;
        if (!doneAxe.activeSelf) {
            ironCountAxe.text = numIron.ToString();
        }
        ironCountPickaxe.text = "";
        pickaxeButton.SetActive(false);
        donePickaxe.SetActive(true);
        if (numIron < 3)
        {
            axeButton.SetActive(false);
        }
    }

    public void craftSifter()
    {
        reedCount.text = "";
        reedButton.SetActive(false);
        done.SetActive(true);
    }
}
