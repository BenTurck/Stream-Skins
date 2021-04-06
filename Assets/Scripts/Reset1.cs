using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class Reset1 : MonoBehaviour
{
	public InputField clearIt;
 
	public void submittingClear()
	{
		clearIt.text = "";
	}
}
