using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class Reset1 : MonoBehaviour
{
	public InputField clearIt;
	public InputField value;
	public Dropdown ddInput;
	public Text TextObject;

	public void SubmittingClear()
	{
		clearIt.text = "";
		ddInput.value = 0;
		TextObject.text = "9";
		value.text = "9";

	}
}
