using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class ValorantWritetoFile : MonoBehaviour
{
	public Dropdown ValorantHomeDDInput;

	private string ValorantHomeStringInput;

	public string ValorantHomeSeriesScoreInput;

	public InputField ValorantHomeSeriesScoreInputField;

	public int ValorantHomeSeriesScoreValue = 0;

	public Dropdown ValorantAwayDDInput;

	private string ValorantAwayStringInput;




	//Start is called before the first frame update
	void Start()
	{
		Directory.CreateDirectory("Assets/Games/Valorant/");
		Directory.CreateDirectory("Assets/TeamLogos/");





		ValorantHomeDDInput.onValueChanged.AddListener(delegate
		{
			ValorantHomeDDValue(ValorantHomeDDInput);

		});

		ValorantAwayDDInput.onValueChanged.AddListener(delegate
		{
			ValorantAwayDDValue(ValorantAwayDDInput);

		});



	}

	// Update is called once per frame
	void Update()
	{

	}

	public void ValorantHomeDDValue(Dropdown sender)
	{
		ValorantHomeStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Home Team Name.txt: " + ValorantHomeStringInput);
		//Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates a directory differently in this path

		string path = "Assets/Games/Valorant/Home Team Name.txt"; // This is the directory for the text file.

		if (ValorantHomeStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = System.IO.Path.Combine(sourcePath, logoBlank);
			string destFile = System.IO.Path.Combine(targetPath, logoHome);

			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (ValorantHomeStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = System.IO.Path.Combine(sourcePath, logoSR);
			string destFile = System.IO.Path.Combine(targetPath, logoHome);

			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);
		}
		if (ValorantHomeStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = System.IO.Path.Combine(sourcePath, logoRIT);
			string destFile = System.IO.Path.Combine(targetPath, logoHome);

			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);

		}

		if (ValorantHomeStringInput != "SELECT TEAM")
		{
			File.WriteAllText(path, ValorantHomeStringInput); // sets the location to path and the contents to input
		}
	}

	public void ValorantHomeSeasonRecord(string s)
	{
		string ValorantHomeSeasonRecordInput = s;

		Debug.Log("Home Team Season Record.txt: " + ValorantHomeSeasonRecordInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Season Record.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeSeasonRecordInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeSeasonRecordInput);
	}

	public void ValorantHomeSeriesScoreIncrement()
	{
		string maxValue = "3";
		string path = "Assets/Games/Valorant/Home Team Series Record.txt";
		if (ValorantHomeSeriesScoreInputField != null && ValorantHomeSeriesScoreInputField.text != maxValue)
		{
			++ValorantHomeSeriesScoreValue;
			ValorantHomeSeriesScoreInput = ValorantHomeSeriesScoreValue.ToString();
			ValorantHomeSeriesScoreInputField.text = ValorantHomeSeriesScoreValue.ToString();
			Debug.Log("Increment - Home Team Series Record.txt: " + ValorantHomeSeriesScoreInputField.text);
			File.WriteAllText(path, ValorantHomeSeriesScoreInputField.text);
		}
	}
	public void ValorantHomeSeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/Valorant/Home Team Series Record.txt";
		if (ValorantHomeSeriesScoreInputField != null && ValorantHomeSeriesScoreInputField.text != minValue)
		{
			--ValorantHomeSeriesScoreValue;
			ValorantHomeSeriesScoreInput = ValorantHomeSeriesScoreValue.ToString();
			ValorantHomeSeriesScoreInputField.text = ValorantHomeSeriesScoreValue.ToString();
			Debug.Log("Decrement - Home Team Series Record.txt: " + ValorantHomeSeriesScoreInputField.text);
			File.WriteAllText(path, ValorantHomeSeriesScoreInputField.text);
		}
	}

	public void ValorantHomeSeriesScore(string s)
	{
		string path = "Assets/Games/Valorant/Home Team Series Record.txt";
		ValorantHomeSeriesScoreInput = s;
		ValorantHomeSeriesScoreInput = ValorantHomeSeriesScoreValue.ToString();
		ValorantHomeSeriesScoreValue = Convert.ToInt32(ValorantHomeSeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Record.txt: " + ValorantHomeSeriesScoreValue);
		File.WriteAllText(path, ValorantHomeSeriesScoreInputField.text);
	}

	public void ValorantHomePlayer1(string s)
	{
		string ValorantHomePlayer1Input = s;

		Debug.Log("Home Team Player1.txt: " + ValorantHomePlayer1Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Player1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer1Input);
	}

	public void ValorantHomePlayer2(string s)
	{
		string ValorantHomePlayer2Input = s;

		Debug.Log("Home Team Player2.txt: " + ValorantHomePlayer2Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer2Input);
	}

	public void ValorantHomePlayer3(string s)
	{
		string ValorantHomePlayer3Input = s;

		Debug.Log("Home Team Player3.txt: " + ValorantHomePlayer3Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer3Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer3Input);
	}

	public void ValorantHomePlayer4(string s)
	{
		string ValorantHomePlayer4Input = s;

		Debug.Log("Home Team Player4.txt: " + ValorantHomePlayer4Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Player4.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer4Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer4Input);
	}

	public void ValorantHomePlayer5(string s)
	{
		string ValorantHomePlayer5Input = s;

		Debug.Log("Home Team Player5.txt: " + ValorantHomePlayer5Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Player5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer5Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer5Input);
	}





	public void ValorantAwayDDValue(Dropdown sender)
	{
		ValorantAwayStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Away Team Name.txt: " + ValorantAwayStringInput);
		//Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates a directory differently in this path

		string path = "Assets/Games/Valorant/Away Team Name.txt"; // This is the directory for the text file.

		if (ValorantAwayStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = System.IO.Path.Combine(sourcePath, logoBlank);
			string destFile = System.IO.Path.Combine(targetPath, logoAway);

			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (ValorantAwayStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = System.IO.Path.Combine(sourcePath, logoSR);
			string destFile = System.IO.Path.Combine(targetPath, logoAway);

			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);
		}
		if (ValorantAwayStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = System.IO.Path.Combine(sourcePath, logoRIT);
			string destFile = System.IO.Path.Combine(targetPath, logoAway);

			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);

		}

		if (ValorantAwayStringInput != "SELECT TEAM")
		{
			File.WriteAllText(path, ValorantAwayStringInput); // sets the location to path and the contents to input
		}
	}


}
