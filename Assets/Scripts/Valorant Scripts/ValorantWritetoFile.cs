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

	private string ValorantHomeDDStringInput;

	public string ValorantHomeSeriesScoreInput;

	public InputField ValorantHomeSeriesScoreInputField;

	public int ValorantHomeSeriesScoreValue = 0;

	public Dropdown ValorantGame1DDInput;

	private string ValorantGame1DDStringInput;

	public Dropdown ValorantGame2DDInput;

	private string ValorantGame2DDStringInput;

	public Dropdown ValorantGame3DDInput;

	private string ValorantGame3DDStringInput;

	public Dropdown ValorantGame4DDInput;

	private string ValorantGame4DDStringInput;

	public Dropdown ValorantGame5DDInput;

	private string ValorantGame5DDStringInput;

	public Dropdown ValorantAwayDDInput;

	private string ValorantAwayDDStringInput;

	public string ValorantAwaySeriesScoreInput;

	public InputField ValorantAwaySeriesScoreInputField;

	public int ValorantAwaySeriesScoreValue = 0;




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

		ValorantGame1DDInput.onValueChanged.AddListener(delegate
		{
			ValorantGame1DDValue(ValorantGame1DDInput);

		});

		ValorantGame2DDInput.onValueChanged.AddListener(delegate
		{
			ValorantGame2DDValue(ValorantGame2DDInput);

		});

		ValorantGame3DDInput.onValueChanged.AddListener(delegate
		{
			ValorantGame3DDValue(ValorantGame3DDInput);

		});

		ValorantGame4DDInput.onValueChanged.AddListener(delegate
		{
			ValorantGame4DDValue(ValorantGame4DDInput);

		});

		ValorantGame5DDInput.onValueChanged.AddListener(delegate
		{
			ValorantGame5DDValue(ValorantGame5DDInput);

		});

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void ValorantTicker(string s)
	{
		string ValorantTickerInput = s;

		Debug.Log("Ticker.txt: " + ValorantTickerInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Ticker.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantTickerInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantTickerInput);
	}

	public void ValorantCaster1(string s)
	{
		string ValorantCaster1Input = s;

		Debug.Log("Caster1.txt: " + ValorantCaster1Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Caster1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantCaster1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantCaster1Input);
	}

	public void ValorantCaster2(string s)
	{
		string ValorantCaster2Input = s;

		Debug.Log("Caster2.txt: " + ValorantCaster2Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Caster2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantCaster2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantCaster2Input);
	}

	public void ValorantHomeGame1Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game1 Winner.txt";
		if (ValorantHomeDDStringInput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log(text1 + ValorantHomeDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void ValorantHomeGame2Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game2 Winner.txt";
		if (ValorantHomeDDStringInput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log(text1 + ValorantHomeDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void ValorantHomeGame3Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game3 Winner.txt";
		if (ValorantHomeDDStringInput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log(text1 + ValorantHomeDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void ValorantHomeGame4Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game4 Winner.txt";
		if (ValorantHomeDDStringInput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log(text1 + ValorantHomeDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void ValorantHomeGame5Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game5 Winner.txt";
		if (ValorantHomeDDStringInput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log(text1 + ValorantHomeDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void ValorantHomeGame1Score(string s)
	{
		string ValorantHomeGame1ScoreInput = s;

		Debug.Log("Home Team Game1 Score.txt: " + ValorantHomeGame1ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Game1 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeGame1ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeGame1ScoreInput);

	}

	public void ValorantHomeGame2Score(string s)
	{
		string ValorantHomeGame2ScoreInput = s;

		Debug.Log("Home Team Game2 Score.txt: " + ValorantHomeGame2ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Game2 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeGame2ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeGame2ScoreInput);
	}

	public void ValorantHomeGame3Score(string s)
	{
		string ValorantHomeGame3ScoreInput = s;

		Debug.Log("Home Team Game3 Score.txt: " + ValorantHomeGame3ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Game3 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeGame3ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeGame3ScoreInput);
	}

	public void ValorantHomeGame4Score(string s)
	{
		string ValorantHomeGame4ScoreInput = s;

		Debug.Log("Home Team Game4 Score.txt: " + ValorantHomeGame4ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Game4 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeGame4ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeGame4ScoreInput);
	}

	public void ValorantHomeGame5Score(string s)
	{
		string ValorantHomeGame5ScoreInput = s;

		Debug.Log("Home Team Game5 Score.txt: " + ValorantHomeGame5ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Game5 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeGame5ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeGame5ScoreInput);
	}

	public void ValorantGame1DDValue(Dropdown sender)
    {
		ValorantGame1DDStringInput = ValorantGame1DDInput.options[ValorantGame1DDInput.value].text;

		string path = "Assets/Games/Valorant/Map1 Name.txt";

		if (ValorantGame1DDStringInput == "SELECT MAP")
        {
			File.WriteAllText(path, "");
			Debug.Log("Map1 Name.txt: ");
		}

		if (ValorantGame1DDStringInput != "SELECT MAP")
        {
			File.WriteAllText(path, ValorantGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + ValorantGame1DDStringInput);
		}
	}

	public void ValorantGame2DDValue(Dropdown sender)
	{
		ValorantGame2DDStringInput = ValorantGame2DDInput.options[ValorantGame2DDInput.value].text;

		string path = "Assets/Games/Valorant/Map2 Name.txt";

		if (ValorantGame2DDStringInput == "SELECT MAP")
		{
			File.WriteAllText(path, "");
			Debug.Log("Map2 Name.txt: ");
		}

		if (ValorantGame2DDStringInput != "SELECT MAP")
		{
			File.WriteAllText(path, ValorantGame2DDStringInput);
			Debug.Log("Map2 Name.txt: " + ValorantGame2DDStringInput);
		}
	}

	public void ValorantGame3DDValue(Dropdown sender)
	{
		ValorantGame3DDStringInput = ValorantGame3DDInput.options[ValorantGame3DDInput.value].text;

		string path = "Assets/Games/Valorant/Map3 Name.txt";

		if (ValorantGame3DDStringInput == "SELECT MAP")
		{
			File.WriteAllText(path, "");
			Debug.Log("Map3 Name.txt: ");
		}

		if (ValorantGame3DDStringInput != "SELECT MAP")
		{
			File.WriteAllText(path, ValorantGame3DDStringInput);
			Debug.Log("Map3 Name.txt: " + ValorantGame3DDStringInput);
		}
	}

	public void ValorantGame4DDValue(Dropdown sender)
	{
		ValorantGame4DDStringInput = ValorantGame4DDInput.options[ValorantGame4DDInput.value].text;

		string path = "Assets/Games/Valorant/Map4 Name.txt";

		if (ValorantGame4DDStringInput == "SELECT MAP")
		{
			File.WriteAllText(path, "");
			Debug.Log("Map4 Name.txt: ");
		}

		if (ValorantGame4DDStringInput != "SELECT MAP")
		{
			File.WriteAllText(path, ValorantGame4DDStringInput);
			Debug.Log("Map4 Name.txt: " + ValorantGame4DDStringInput);
		}
	}

	public void ValorantGame5DDValue(Dropdown sender)
	{
		ValorantGame5DDStringInput = ValorantGame5DDInput.options[ValorantGame5DDInput.value].text;

		string path = "Assets/Games/Valorant/Map5 Name.txt";

		if (ValorantGame5DDStringInput == "SELECT MAP")
		{
			File.WriteAllText(path, "");
			Debug.Log("Map5 Name.txt: ");
		}

		if (ValorantGame5DDStringInput != "SELECT MAP")
		{
			File.WriteAllText(path, ValorantGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + ValorantGame5DDStringInput);
		}
	}

	public void ValorantAwayGame1Score(string s)
	{
		string ValorantAwayGame1ScoreInput = s;

		Debug.Log("Away Team Game1 Score.txt: " + ValorantAwayGame1ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Game1 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayGame1ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayGame1ScoreInput);

	}

	public void ValorantAwayGame2Score(string s)
	{
		string ValorantAwayGame2ScoreInput = s;

		Debug.Log("Away Team Game2 Score.txt: " + ValorantAwayGame2ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Game2 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayGame2ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayGame2ScoreInput);
	}

	public void ValorantAwayGame3Score(string s)
	{
		string ValorantAwayGame3ScoreInput = s;

		Debug.Log("Away Team Game3 Score.txt: " + ValorantAwayGame3ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Game3 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayGame3ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayGame3ScoreInput);
	}

	public void ValorantAwayGame4Score(string s)
	{
		string ValorantAwayGame4ScoreInput = s;

		Debug.Log("Away Team Game4 Score.txt: " + ValorantAwayGame4ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Game4 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayGame4ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayGame4ScoreInput);
	}

	public void ValorantAwayGame5Score(string s)
	{
		string ValorantAwayGame5ScoreInput = s;

		Debug.Log("Away Team Game5 Score.txt: " + ValorantAwayGame5ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Game5 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayGame5ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayGame5ScoreInput);
	}

	public void ValorantAwayGame1Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game1 Winner.txt";
		if (ValorantAwayDDStringInput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log(text1 + ValorantAwayDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void ValorantAwayGame2Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game2 Winner.txt";
		if (ValorantAwayDDStringInput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log(text1 + ValorantAwayDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void ValorantAwayGame3Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game3 Winner.txt";
		if (ValorantAwayDDStringInput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log(text1 + ValorantAwayDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void ValorantAwayGame4Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game4 Winner.txt";
		if (ValorantAwayDDStringInput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log(text1 + ValorantAwayDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void ValorantAwayGame5Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game5 Winner.txt";
		if (ValorantAwayDDStringInput == "SELECT TEAM")
		{
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				Debug.Log(text1 + ValorantAwayDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void ValorantHomeDDValue(Dropdown sender)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Home Team Name.txt: " + ValorantHomeDDStringInput);
		//Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates a directory differently in this path

		string path = "Assets/Games/Valorant/Home Team Name.txt"; // This is the directory for the text file.

		if (ValorantHomeDDStringInput == "SELECT TEAM")
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

		if (ValorantHomeDDStringInput == "SAINT ROSE")
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
		if (ValorantHomeDDStringInput == "RIT")

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

		if (ValorantHomeDDStringInput != "SELECT TEAM")
		{
			File.WriteAllText(path, ValorantHomeDDStringInput); // sets the location to path and the contents to input
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
		string path = "Assets/Games/Valorant/Home Team Series Score.txt";
		if (ValorantHomeSeriesScoreInputField != null && ValorantHomeSeriesScoreInputField.text != maxValue)
		{
			++ValorantHomeSeriesScoreValue;
			ValorantHomeSeriesScoreInput = ValorantHomeSeriesScoreValue.ToString();
			ValorantHomeSeriesScoreInputField.text = ValorantHomeSeriesScoreValue.ToString();
			Debug.Log("Increment - Home Team Series Score.txt: " + ValorantHomeSeriesScoreInputField.text);
			File.WriteAllText(path, ValorantHomeSeriesScoreInputField.text);
		}
	}

	public void ValorantHomeSeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/Valorant/Home Team Series Score.txt";
		if (ValorantHomeSeriesScoreInputField != null && ValorantHomeSeriesScoreInputField.text != minValue)
		{
			--ValorantHomeSeriesScoreValue;
			ValorantHomeSeriesScoreInput = ValorantHomeSeriesScoreValue.ToString();
			ValorantHomeSeriesScoreInputField.text = ValorantHomeSeriesScoreValue.ToString();
			Debug.Log("Decrement - Home Team Series Score.txt: " + ValorantHomeSeriesScoreInputField.text);
			File.WriteAllText(path, ValorantHomeSeriesScoreInputField.text);
		}
	}

	public void ValorantHomeSeriesScore(string s)
	{
		string path = "Assets/Games/Valorant/Home Team Series Score.txt";
		ValorantHomeSeriesScoreInput = s;
		ValorantHomeSeriesScoreInput = ValorantHomeSeriesScoreValue.ToString();
		ValorantHomeSeriesScoreValue = Convert.ToInt32(ValorantHomeSeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Score.txt: " + ValorantHomeSeriesScoreValue);
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
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Away Team Name.txt: " + ValorantAwayDDStringInput);
		//Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates a directory differently in this path

		string path = "Assets/Games/Valorant/Away Team Name.txt"; // This is the directory for the text file.

		if (ValorantAwayDDStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoHome = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = System.IO.Path.Combine(sourcePath, logoBlank);
			string destFile = System.IO.Path.Combine(targetPath, logoHome);

			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (ValorantAwayDDStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoHome = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = System.IO.Path.Combine(sourcePath, logoSR);
			string destFile = System.IO.Path.Combine(targetPath, logoHome);

			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);
		}
		if (ValorantAwayDDStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoHome = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = System.IO.Path.Combine(sourcePath, logoRIT);
			string destFile = System.IO.Path.Combine(targetPath, logoHome);

			System.IO.Directory.CreateDirectory(targetPath);
			System.IO.File.Copy(sourceFile, destFile, true);

		}

		if (ValorantAwayDDStringInput != "SELECT TEAM")
		{
			File.WriteAllText(path, ValorantAwayDDStringInput); // sets the location to path and the contents to input
		}
	}

	public void ValorantAwaySeasonRecord(string s)
	{
		string ValorantAwaySeasonRecordInput = s;

		Debug.Log("Away Team Season Record.txt: " + ValorantAwaySeasonRecordInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Season Record.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwaySeasonRecordInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwaySeasonRecordInput);
	}

	public void ValorantAwaySeriesScoreIncrement()
	{
		string maxValue = "3";
		string path = "Assets/Games/Valorant/Away Team Series Score.txt";
		if (ValorantAwaySeriesScoreInputField != null && ValorantAwaySeriesScoreInputField.text != maxValue)
		{
			++ValorantAwaySeriesScoreValue;
			ValorantAwaySeriesScoreInput = ValorantAwaySeriesScoreValue.ToString();
			ValorantAwaySeriesScoreInputField.text = ValorantAwaySeriesScoreValue.ToString();
			Debug.Log("Increment - Away Team Series Score.txt: " + ValorantAwaySeriesScoreInputField.text);
			File.WriteAllText(path, ValorantAwaySeriesScoreInputField.text);
		}
	}

	public void ValorantAwaySeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/Valorant/Away Team Series Score.txt";
		if (ValorantAwaySeriesScoreInputField != null && ValorantAwaySeriesScoreInputField.text != minValue)
		{
			--ValorantAwaySeriesScoreValue;
			ValorantAwaySeriesScoreInput = ValorantAwaySeriesScoreValue.ToString();
			ValorantAwaySeriesScoreInputField.text = ValorantAwaySeriesScoreValue.ToString();
			Debug.Log("Decrement - Away Team Series Score.txt: " + ValorantAwaySeriesScoreInputField.text);
			File.WriteAllText(path, ValorantAwaySeriesScoreInputField.text);
		}
	}

	public void ValorantAwaySeriesScore(string s)
	{
		string path = "Assets/Games/Valorant/Away Team Series Score.txt";
		ValorantAwaySeriesScoreInput = s;
		ValorantAwaySeriesScoreInput = ValorantAwaySeriesScoreValue.ToString();
		ValorantAwaySeriesScoreValue = Convert.ToInt32(ValorantAwaySeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Score.txt: " + ValorantAwaySeriesScoreValue);
		File.WriteAllText(path, ValorantAwaySeriesScoreInputField.text);
	}

	public void ValorantAwayPlayer1(string s)
	{
		string ValorantAwayPlayer1Input = s;

		Debug.Log("Away Team Player1.txt: " + ValorantAwayPlayer1Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Player1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayPlayer1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayPlayer1Input);
	}

	public void ValorantAwayPlayer2(string s)
	{
		string ValorantAwayPlayer2Input = s;

		Debug.Log("Away Team Player2.txt: " + ValorantAwayPlayer2Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayPlayer2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayPlayer2Input);
	}

	public void ValorantAwayPlayer3(string s)
	{
		string ValorantAwayPlayer3Input = s;

		Debug.Log("Away Team Player3.txt: " + ValorantAwayPlayer3Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayPlayer3Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayPlayer3Input);
	}

	public void ValorantAwayPlayer4(string s)
	{
		string ValorantAwayPlayer4Input = s;

		Debug.Log("Away Team Player4.txt: " + ValorantAwayPlayer4Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Player4.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayPlayer4Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayPlayer4Input);
	}

	public void ValorantAwayPlayer5(string s)
	{
		string ValorantHomePlayer5Input = s;

		Debug.Log("Away Team Player5.txt: " + ValorantHomePlayer5Input); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Player5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer5Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer5Input);
	}

}
