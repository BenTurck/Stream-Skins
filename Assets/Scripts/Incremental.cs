using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class Incremental : MonoBehaviour
{
    public int Value = 9;
    public Text TextObject = null;
    public string maxValue = "9";
    public string minValue = "0";

    public void Increment()
    {
        if (TextObject != null && TextObject.text != maxValue)
        {
            ++Value;
            TextObject.text = Value.ToString();
        }

    }

    public void Decrement()
    {
        if (TextObject != null && TextObject.text != minValue)
        {
            --Value;
            TextObject.text = Value.ToString();
        }

    }
}
