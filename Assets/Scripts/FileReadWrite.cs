using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class FileReadWrite : MonoBehaviour
{
	public Dropdown ddInput;
	private string homeinput;
	public int Value = 9;
	public Text TextObject = null;

	void Start()
	{
		ddInput.onValueChanged.AddListener(delegate
	{
		ddInputValueChangedHappened(ddInput);
	});
	}

	public void ddInputValueChangedHappened(Dropdown sender)
	{
		homeinput = ddInput.options[ddInput.value].text;
		Debug.Log("Home Team Name.txt: " + homeinput);
		Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates a directory differently in this path

		string path = "Assets/Games/Smash Bros/Home Team Name.txt"; // This is the directory for the text file.

		if (homeinput == "SELECT TEAM")
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

		if (homeinput == "SAINT ROSE")
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
		if (homeinput == "RIT")

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

		if (homeinput != "SELECT TEAM")
		{
			File.WriteAllText(path, homeinput); // sets the location to path and the contents to input
		}
	}

	public void ReadStringInput(string s)
	{
		homeinput = s; // sets string input to string s
		Debug.Log("Home Team Stocks: " + homeinput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates directory in this path
															   // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															   // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Smash Bros/Home Team Extra.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, homeinput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, homeinput); // sets the location to path and the contents to input
	}

	public void ReadTopToggleInput(bool tog)
	{
		homeinput = ddInput.options[ddInput.value].text;
		Debug.Log("Home Team Map1: " + tog);
		string text1 = "Map 1: ";
		string text2 = " Won";
		string bothinput = text1 + homeinput + text2;
		string path = "Assets/Games/Smash Bros/Map1 Winner.txt";
		if (homeinput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log("I AM TRUE");
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log("I AM FALSE");
				File.WriteAllText(path, "");
			}
		}
	}
	public void ReadBottomToggleInput(bool tog)
	{
		homeinput = ddInput.options[ddInput.value].text;
		Debug.Log("Away Team Map1: " + tog);
		string text1 = "Map 1: ";
		string text2 = " Won";
		string bothinput = text1 + homeinput + text2;
		string path = "Assets/Games/Smash Bros/Map1 Winner.txt";
		if (homeinput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log("I AM TRUE");
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log("I AM FALSE");
				File.WriteAllText(path, "");
			}
		}
	}
	public void Increment()
	{
		string maxValue = "9";
		string path = "Assets/Games/Smash Bros/Home Team Stocks.txt";
		if (TextObject != null && TextObject.text != maxValue)
		{
			++Value;
			TextObject.text = Value.ToString();
			Debug.Log(TextObject.text);
			File.WriteAllText(path, TextObject.text);
		}

	}
	public void Decrement()
	{;
		string minValue = "0";
		string path = "Assets/Games/Smash Bros/Home Team Stocks.txt";
		if (TextObject != null && TextObject.text != minValue)
		{
			--Value;
			TextObject.text = Value.ToString();
			Debug.Log(TextObject.text);
			File.WriteAllText(path, TextObject.text);
		}

	}
}
