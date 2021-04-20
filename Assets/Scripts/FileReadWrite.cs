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
	public InputField TextObject = null;
	public string input;
	private string activeplayer;
	private string homeplayer1;
	private string homeplayer2;
	private string homeplayer3;
	private Toggle hp1;


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
			input = Value.ToString();
			TextObject.text = Value.ToString();
			Debug.Log("Increment: " + TextObject.text);
			File.WriteAllText(path, TextObject.text);
		}

	}
	public void Decrement()
	{
		string minValue = "0";
		string path = "Assets/Games/Smash Bros/Home Team Stocks.txt";
		if (TextObject != null && TextObject.text != minValue)
		{
			--Value;
			input = Value.ToString();
			TextObject.text = Value.ToString();
			Debug.Log("Decrement: " + TextObject.text);
			File.WriteAllText(path, TextObject.text);
		}

	}
	public void Test(String t)
	{
		string path = "Assets/Games/Smash Bros/Home Team Stocks.txt";
		input = t;
		input = Value.ToString();
		Value = Convert.ToInt32(TextObject.text);
		Debug.Log("String: " + Value);
		File.WriteAllText(path, TextObject.text);
	}

	public void HomePlayer1(string s)
	{
		homeplayer1 = s; // sets string input to string s
		Debug.Log("Home Team Player1: " + homeplayer1); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates directory in this path
															   // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called                                                 // streamingAssetsPath, LIVE_DATA, and Smash Bros
		

		string path = "Assets/Games/Smash Bros/Home Team Player1.txt"; // This is the directory for the text file.

		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, homeplayer1); // sets the location to path and the contents to input inside if statement
		}
		File.WriteAllText(path, homeplayer1); // sets the location to path and the contents to input
	}
	
	public void HomePlayer2(string s)
	{
		homeplayer2 = s; // sets string input to string s
		Debug.Log("Home Team Player2: " + homeplayer2); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates directory in this path
															   // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															   // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Smash Bros/Home Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, homeplayer2); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, homeplayer2); // sets the location to path and the contents to input
	}

	public void HomePlayer3(string s)
	{
		homeplayer3 = s; // sets string input to string s
		Debug.Log("Home Team Player3: " + homeplayer3); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates directory in this path
															   // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															   // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Smash Bros/Home Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, homeplayer3); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, homeplayer3); // sets the location to path and the contents to input
	}

	public void HomeActivePlayer1(bool tog)
	{
		string path = "Assets/Games/Smash Bros/Home Team Active Player.txt";
		if (tog == true)
        {
			Debug.Log("Home Team Active Player: " + homeplayer1);
			File.WriteAllText(path, homeplayer1);
		}
		else
        {
			Debug.Log("Home Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

}
