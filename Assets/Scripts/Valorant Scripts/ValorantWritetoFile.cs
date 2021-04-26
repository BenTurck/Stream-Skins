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

	public Dropdown ValorantMap1DDInput;

	private string ValorantMap1DDStringInput;

	public Dropdown ValorantMap2DDInput;

	private string ValorantMap2DDStringInput;

	public Dropdown ValorantMap3DDInput;

	private string ValorantMap3DDStringInput;

	public Dropdown ValorantMap4DDInput;

	private string ValorantMap4DDStringInput;

	public Dropdown ValorantMap5DDInput;

	private string ValorantMap5DDStringInput;

	public string ValorantHomeMap1ScoreInput;

	public string ValorantAwayMap1ScoreInput;

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

		ValorantMap1DDInput.onValueChanged.AddListener(delegate
		{
			ValorantMap1DDValue(ValorantMap1DDInput);

		});

		ValorantMap2DDInput.onValueChanged.AddListener(delegate
		{
			ValorantMap2DDValue(ValorantMap2DDInput);

		});

		ValorantMap3DDInput.onValueChanged.AddListener(delegate
		{
			ValorantMap3DDValue(ValorantMap3DDInput);

		});

		ValorantMap4DDInput.onValueChanged.AddListener(delegate
		{
			ValorantMap4DDValue(ValorantMap4DDInput);

		});

		ValorantMap5DDInput.onValueChanged.AddListener(delegate
		{
			ValorantMap5DDValue(ValorantMap5DDInput);

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

	public void ValorantHomeMap1Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Map1 Winner.txt: " + tog);
		string text1 = "Map 1: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Map1 Winner.txt";
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

	public void ValorantHomeMap2Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Map2 Winner.txt: " + tog);
		string text1 = "Map 2: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Map2 Winner.txt";
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

	public void ValorantHomeMap3Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Map3 Winner.txt: " + tog);
		string text1 = "Map 3: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Map3 Winner.txt";
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

	public void ValorantHomeMap4Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Map4 Winner.txt: " + tog);
		string text1 = "Map 4: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Map4 Winner.txt";
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

	public void ValorantHomeMap5Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Map5 Winner.txt: " + tog);
		string text1 = "Map 5: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Map5 Winner.txt";
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

	public void ValorantHomeMap1Score(string s)
	{
		string ValorantHomeMap1ScoreInput = s;

		Debug.Log("Home Team Map1 Score.txt: " + ValorantHomeMap1ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Map1 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeMap1ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeMap1ScoreInput);

	}

	public void ValorantHomeMap2Score(string s)
	{
		string ValorantHomeMap2ScoreInput = s;

		Debug.Log("Home Team Map2 Score.txt: " + ValorantHomeMap2ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Map2 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeMap2ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeMap2ScoreInput);
	}

	public void ValorantHomeMap3Score(string s)
	{
		string ValorantHomeMap3ScoreInput = s;

		Debug.Log("Home Team Map3 Score.txt: " + ValorantHomeMap3ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Map3 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeMap3ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeMap3ScoreInput);
	}

	public void ValorantHomeMap4Score(string s)
	{
		string ValorantHomeMap4ScoreInput = s;

		Debug.Log("Home Team Map4 Score.txt: " + ValorantHomeMap4ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Map4 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeMap4ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeMap4ScoreInput);
	}

	public void ValorantHomeMap5Score(string s)
	{
		string ValorantHomeMap5ScoreInput = s;

		Debug.Log("Home Team Map5 Score.txt: " + ValorantHomeMap5ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Home Team Map5 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomeMap5ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomeMap5ScoreInput);
	}

	public void ValorantMap1DDValue(Dropdown sender)
    {
		ValorantMap1DDStringInput = ValorantMap1DDInput.options[ValorantMap1DDInput.value].text;

		string path = "Assets/Games/Valorant/Map1 Name.txt";

		if (ValorantMap1DDStringInput == "SELECT MAP")
        {
			File.WriteAllText(path, "");
			Debug.Log("Map1 Name.txt: ");
		}

		if (ValorantMap1DDStringInput != "SELECT MAP")
        {
			File.WriteAllText(path, ValorantMap1DDStringInput);
			Debug.Log("Map1 Name.txt: " + ValorantMap1DDStringInput);
		}
	}

	public void ValorantMap2DDValue(Dropdown sender)
	{
		ValorantMap2DDStringInput = ValorantMap2DDInput.options[ValorantMap2DDInput.value].text;

		string path = "Assets/Games/Valorant/Map2 Name.txt";

		if (ValorantMap2DDStringInput == "SELECT MAP")
		{
			File.WriteAllText(path, "");
			Debug.Log("Map2 Name.txt: ");
		}

		if (ValorantMap2DDStringInput != "SELECT MAP")
		{
			File.WriteAllText(path, ValorantMap2DDStringInput);
			Debug.Log("Map2 Name.txt: " + ValorantMap2DDStringInput);
		}
	}

	public void ValorantMap3DDValue(Dropdown sender)
	{
		ValorantMap3DDStringInput = ValorantMap3DDInput.options[ValorantMap3DDInput.value].text;

		string path = "Assets/Games/Valorant/Map3 Name.txt";

		if (ValorantMap3DDStringInput == "SELECT MAP")
		{
			File.WriteAllText(path, "");
			Debug.Log("Map3 Name.txt: ");
		}

		if (ValorantMap3DDStringInput != "SELECT MAP")
		{
			File.WriteAllText(path, ValorantMap3DDStringInput);
			Debug.Log("Map3 Name.txt: " + ValorantMap3DDStringInput);
		}
	}

	public void ValorantMap4DDValue(Dropdown sender)
	{
		ValorantMap4DDStringInput = ValorantMap4DDInput.options[ValorantMap4DDInput.value].text;

		string path = "Assets/Games/Valorant/Map4 Name.txt";

		if (ValorantMap4DDStringInput == "SELECT MAP")
		{
			File.WriteAllText(path, "");
			Debug.Log("Map4 Name.txt: ");
		}

		if (ValorantMap4DDStringInput != "SELECT MAP")
		{
			File.WriteAllText(path, ValorantMap4DDStringInput);
			Debug.Log("Map4 Name.txt: " + ValorantMap4DDStringInput);
		}
	}

	public void ValorantMap5DDValue(Dropdown sender)
	{
		ValorantMap5DDStringInput = ValorantMap5DDInput.options[ValorantMap5DDInput.value].text;

		string path = "Assets/Games/Valorant/Map5 Name.txt";

		if (ValorantMap5DDStringInput == "SELECT MAP")
		{
			File.WriteAllText(path, "");
			Debug.Log("Map5 Name.txt: ");
		}

		if (ValorantMap5DDStringInput != "SELECT MAP")
		{
			File.WriteAllText(path, ValorantMap5DDStringInput);
			Debug.Log("Map5 Name.txt: " + ValorantMap5DDStringInput);
		}
	}

	public void ValorantAwayMap1Score(string s)
	{
		string ValorantAwayMap1ScoreInput = s;

		Debug.Log("Away Team Map1 Score.txt: " + ValorantAwayMap1ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Map1 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayMap1ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayMap1ScoreInput);

	}

	public void ValorantAwayMap2Score(string s)
	{
		string ValorantAwayMap2ScoreInput = s;

		Debug.Log("Away Team Map2 Score.txt: " + ValorantAwayMap2ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Map2 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayMap2ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayMap2ScoreInput);
	}

	public void ValorantAwayMap3Score(string s)
	{
		string ValorantAwayMap3ScoreInput = s;

		Debug.Log("Away Team Map3 Score.txt: " + ValorantAwayMap3ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Map3 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayMap3ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayMap3ScoreInput);
	}

	public void ValorantAwayMap4Score(string s)
	{
		string ValorantAwayMap4ScoreInput = s;

		Debug.Log("Away Team Map4 Score.txt: " + ValorantAwayMap4ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Map4 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayMap4ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayMap4ScoreInput);
	}

	public void ValorantAwayMap5Score(string s)
	{
		string ValorantAwayMap5ScoreInput = s;

		Debug.Log("Away Team Map5 Score.txt: " + ValorantAwayMap5ScoreInput); // shows input in debug

		Directory.CreateDirectory("Assets/Games/Valorant/"); // creates directory in this path
															 // Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
															 // streamingAssetsPath, LIVE_DATA, and Smash Bros

		string path = "Assets/Games/Valorant/Away Team Map5 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayMap5ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayMap5ScoreInput);
	}

	public void ValorantAwayMap1Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Map1 Winner.txt: " + tog);
		string text1 = "Map 1: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Map1 Winner.txt";
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

	public void ValorantAwayMap2Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Map2 Winner.txt: " + tog);
		string text1 = "Map 2: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Map2 Winner.txt";
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

	public void ValorantAwayMap3Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Map3 Winner.txt: " + tog);
		string text1 = "Map 3: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Map3 Winner.txt";
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

	public void ValorantAwayMap4Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Map4 Winner.txt: " + tog);
		string text1 = "Map 4: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Map4 Winner.txt";
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

	public void ValorantAwayMap5Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Map5 Winner.txt: " + tog);
		string text1 = "Map 5: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Map5 Winner.txt";
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
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Away Team Name.txt: " + ValorantAwayDDStringInput);
		//Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates a directory differently in this path

		string path = "Assets/Games/Valorant/Away Team Name.txt"; // This is the directory for the text file.

		if (ValorantAwayDDStringInput == "SELECT TEAM")
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

		if (ValorantAwayDDStringInput == "SAINT ROSE")
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
		if (ValorantAwayDDStringInput == "RIT")

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
		string path = "Assets/Games/Valorant/Away Team Series Record.txt";
		if (ValorantAwaySeriesScoreInputField != null && ValorantAwaySeriesScoreInputField.text != maxValue)
		{
			++ValorantAwaySeriesScoreValue;
			ValorantAwaySeriesScoreInput = ValorantAwaySeriesScoreValue.ToString();
			ValorantAwaySeriesScoreInputField.text = ValorantAwaySeriesScoreValue.ToString();
			Debug.Log("Increment - Away Team Series Record.txt: " + ValorantAwaySeriesScoreInputField.text);
			File.WriteAllText(path, ValorantAwaySeriesScoreInputField.text);
		}
	}

	public void ValorantAwaySeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/Valorant/Away Team Series Record.txt";
		if (ValorantAwaySeriesScoreInputField != null && ValorantAwaySeriesScoreInputField.text != minValue)
		{
			--ValorantAwaySeriesScoreValue;
			ValorantAwaySeriesScoreInput = ValorantAwaySeriesScoreValue.ToString();
			ValorantAwaySeriesScoreInputField.text = ValorantAwaySeriesScoreValue.ToString();
			Debug.Log("Decrement - Away Team Series Record.txt: " + ValorantAwaySeriesScoreInputField.text);
			File.WriteAllText(path, ValorantAwaySeriesScoreInputField.text);
		}
	}

	public void ValorantAwaySeriesScore(string s)
	{
		string path = "Assets/Games/Valorant/Away Team Series Record.txt";
		ValorantAwaySeriesScoreInput = s;
		ValorantAwaySeriesScoreInput = ValorantAwaySeriesScoreValue.ToString();
		ValorantAwaySeriesScoreValue = Convert.ToInt32(ValorantAwaySeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Record.txt: " + ValorantAwaySeriesScoreValue);
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
