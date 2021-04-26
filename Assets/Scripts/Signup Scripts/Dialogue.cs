using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * System Serializable is something you put 
 * above a class if you want the values added
 * to the script to show up on the inspector
 * in order to edit the classes variables there.
 * Syntax relating to a function being called within
 * brackets is often a sign you're changing something
 * on the inspector.
 */

[System.Serializable]
public class Dialogue
{
    public string name;
    
    [TextArea(3,10)]
    public string[] sentences;
}
