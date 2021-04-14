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
    public InputField TextObject = null;
    public string maxValue = "9";
    public string minValue = "0";
    public string input;
    public void Increment()
    {
        if (TextObject != null && TextObject.text != maxValue)
        {
            ++Value;
            input = Value.ToString();
            TextObject.text = Value.ToString();
        }

    }

    public void Decrement()
    {
        if (TextObject != null && TextObject.text != minValue)
        {
            --Value;
            input = Value.ToString();
            TextObject.text = Value.ToString();
        }

    }
    public void Test(String t)
    {
        input = t;
        input = Value.ToString();
        Value = Convert.ToInt32(TextObject.text);
        //TextObject.text = Value.ToString();
        Debug.Log(Value);
    }
}
