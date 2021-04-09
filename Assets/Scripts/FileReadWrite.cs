<<<<<<< HEAD
using System;
=======
>>>>>>> df626e7 (awsTest)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class FileReadWrite : MonoBehaviour
{
	public Dropdown ddInput;
	private string input;
	
	void Start()
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
		
		string path = "Assets/Games/Smash Bros/Test5.txt"; // This is the directory for the text file.
		
		if (input == "SELECT TEAM")
		{
			string fileName1 = "Blank.png";
			string fileName2 = "Home Logo.png";
			string sourcePath = "Assets/Games/Smash Bros/";
        		string targetPath = "Assets/";
		
			string sourceFile = System.IO.Path.Combine(sourcePath, fileName1);
			string destFile = System.IO.Path.Combine(targetPath, fileName2);
		
			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}
						
		if (input == "SAINT ROSE")
		{
			string fileName1 = "SR LOGO.png";
			string fileName2 = "Home Logo.png";
			string sourcePath = "Assets/Games/Smash Bros/";
        		string targetPath = "Assets/";
		
			string sourceFile = System.IO.Path.Combine(sourcePath, fileName1);
			string destFile = System.IO.Path.Combine(targetPath, fileName2);
		
			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);
		}
		if (input == "RIT")

		{
			string fileName1 = "RIT Logo.png";
			string fileName2 = "Home Logo.png";
			string sourcePath = "Assets/Games/Smash Bros/";
        		string targetPath = "Assets/";
		
			string sourceFile = System.IO.Path.Combine(sourcePath, fileName1);
			string destFile = System.IO.Path.Combine(targetPath, fileName2);
		
			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);
			
		}
		
		if (input != "SELECT TEAM")
		{
			File.WriteAllText(path, input); // sets the location to path and the contents to input
		}
	}

	public void ReadStringInput(string s)
	{
		input = s; // sets string input to string s
		Debug.Log(input); // shows input in debug
		
		Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates directory in this path
						// Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
						// streamingAssetsPath, LIVE_DATA, and Smash Bros
		
		string path = "Assets/Games/Smash Bros/Test6.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, input); // sets the location to path and the contents to input inside if statement
		}
		
		File.WriteAllText(path, input); // sets the location to path and the contents to input
	}

	public void ReadImageInput()
	{
		string fileName1 = "Test7.png";
		string fileName2 = "Test8.png";
		string sourcePath = "Assets/Games/Smash Bros/";
        	string targetPath = "Assets/";
		
		string sourceFile = System.IO.Path.Combine(sourcePath, fileName1);
		string destFile = System.IO.Path.Combine(targetPath, fileName2);
		
		System.IO.Directory.CreateDirectory(targetPath);
		System.IO.File.Copy(sourceFile, destFile, true);

	}
	public void ResetInputs()
	{
		/*
		string path = "Assets/Games/Smash Bros/Test6.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, input); // sets the location to path and the contents to input inside if statement
		}
		path = "Assets/Games/Smash Bros/Test5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, input); // sets the location to path and the contents to input inside if statement
		}
		
		string fileName = "Blank.png";
		string sourcePath = "Assets/Games/Smash Bros/";
        	string targetPath = "Assets/";
		
		string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
		string destFile = System.IO.Path.Combine(targetPath, fileName);
		
		System.IO.Directory.CreateDirectory(targetPath);
		System.IO.File.Copy(sourceFile, destFile, true);
		*/
		
	}

}
