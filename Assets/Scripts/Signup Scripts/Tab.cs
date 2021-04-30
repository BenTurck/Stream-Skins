using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading.Tasks;

public class Tab : MonoBehaviour
{
    public InputField nextField;

    // Update is called once per frame
    void Update()
    {

        if (GetComponent<InputField>().isFocused && Input.GetKeyDown(KeyCode.Tab))
        {
            nextField.ActivateInputField();

        }
    }
}


