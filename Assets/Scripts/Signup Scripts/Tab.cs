using UnityEngine;
using UnityEngine.UI;

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