using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggsScript : MonoBehaviour
{
    public int numEggs = 0;

    public void foundEgg()
    {
        numEggs++;
    }
}
