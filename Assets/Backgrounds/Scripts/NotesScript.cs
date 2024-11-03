using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesScript : MonoBehaviour
{
    public GameObject logic;

    public void openNotes()
    {
        logic.GetComponent<LogicScript>().switchNotes();
    }
    public void closeNotes()
    {
        logic.GetComponent<LogicScript>().switchMenu();
    }
}
