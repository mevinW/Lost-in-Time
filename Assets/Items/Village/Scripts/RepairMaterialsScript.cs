using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepairMaterialsScript : MonoBehaviour
{
    public Text stickCount;
    public int numSticks = 0;

    public Text sandCount;
    public int numSand = 0;

    public Text glassCount;
    public int numGlass = 0;

    public Text crabCount;
    public int numCrabs = 0;

    public Text coreCount;
    public int numCores = 0;

    public Text crystalCount;
    public int numCrystals = 0;

    public GameObject window;
    public GameObject doneWindow;
    public Text glassCountWindow;

    public GameObject powerCore;
    public GameObject donePowerCore;

    public GameObject frame;
    public GameObject doneFrame;


    public void addStick()
    {
        numSticks++;
        if(numSticks >= 4)
        {
            frame.SetActive(true);
        }
        stickCount.text = numSticks.ToString() + "/4";
    }

    public void addSand()
    {
        numSand++;
        sandCount.text = numSand.ToString();
    }

    public void addGlass(int num)
    {
        numGlass += num;
        if (numGlass >= 2)
        {
            window.SetActive(true);
        }
        glassCount.text = numGlass.ToString();
        glassCountWindow.text = numGlass.ToString() + "/2";
    }

    public void addCrab()
    {
        numCrabs++;
        crabCount.text = numCrabs.ToString();
    }

    public void addCore()
    {
        numCores++;
        if (numCores >= 1 && numCrystals >= 4)
        {
            powerCore.SetActive(true);
        }
        coreCount.text = numCores.ToString();
    }

    public void addCrystal()
    {
        numCrystals++;
        if (numCores >= 1 && numCrystals >= 4)
        {
            powerCore.SetActive(true);
        }
        crystalCount.text = numCrystals.ToString() + "/4";
    }

    public void craftWindow()
    {
        numGlass -= 2;
        glassCountWindow.text = "";
        glassCount.text = numGlass.ToString();
        window.SetActive(false);
        doneWindow.SetActive(true);
    }

    public void craftPowerCore()
    {
        numCores -= 1;
        coreCount.text = "";
        numCrystals -= 4;
        crystalCount.text = "";
        powerCore.SetActive(false);
        donePowerCore.SetActive(true);
    }

    public void craftFrame()
    {
        numSticks -= 4;
        stickCount.text = "";
        frame.SetActive(false);
        doneFrame.SetActive(true);
    }
}
