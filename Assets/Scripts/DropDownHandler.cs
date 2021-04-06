using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class DropDownHandler : MonoBehaviour
{
	public Dropdown ddInput;
	private string input = "";
	
	private void Start()
	{
		ddInput.onValueChanged.AddListener(delegate
		{
			ddInputValueChangedHappened(ddInput);
		});
	}
	
	public void ddInputValueChangedHappened(Dropdown sender)
	{
		input = ddInput.options[ddInput.value].text;
		Debug.Log("DropDownHandler.cs: " + input);

		Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates a directory differently in this path
						
		
		string path = "Assets/Games/Smash Bros/Test3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, input); // sets the location to path and the contents to input inside if statement
		}
		
		File.WriteAllText(path, input); // sets the location to path and the contents to input
	}
}



