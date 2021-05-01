using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Amazon.DynamoDBv2;

public class SmashBrosWritetoFile : MonoBehaviour
{
	public Dropdown SmashBrosHomeDDInput;

	private string SmashBrosHomeDDStringInput;

	public string SmashBrosHomeSeriesScoreInput;

	public InputField SmashBrosHomeSeriesScoreInputField;

	public int SmashBrosHomeSeriesScoreValue = 0;

	public string SmashBrosHomeStocksInput;

	public InputField SmashBrosHomeStocksInputField;

	public int SmashBrosHomeStocksValue = 9;

	private string SmashBrosHomePlayer1Input;

	private string SmashBrosHomePlayer2Input;

	private string SmashBrosHomePlayer3Input;

	public Dropdown SmashBrosAwayDDInput;

	private string SmashBrosAwayDDStringInput;

	public string SmashBrosAwaySeriesScoreInput;

	public InputField SmashBrosAwaySeriesScoreInputField;

	public int SmashBrosAwaySeriesScoreValue = 0;

	public string SmashBrosAwayStocksInput;

	public InputField SmashBrosAwayStocksInputField;

	public int SmashBrosAwayStocksValue = 9;

	private string SmashBrosAwayPlayer1Input;

	private string SmashBrosAwayPlayer2Input;

	private string SmashBrosAwayPlayer3Input;




	//Start is called before the first frame update
	void Start()
	{
		SmashBrosHomeDDInput.onValueChanged.AddListener(delegate
		{
			SmashBrosHomeDDValue(SmashBrosHomeDDInput);

		});

		SmashBrosAwayDDInput.onValueChanged.AddListener(delegate
		{
			SmashBrosAwayDDValue(SmashBrosAwayDDInput);

		});

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void SmashBrosTicker(string s)
	{
		string SmashBrosTickerInput = s;

		Debug.Log("Ticker.txt: " + SmashBrosTickerInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Ticker.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosTickerInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosTickerInput);
	}

	public void SmashBrosCaster1(string s)
	{
		string SmashBrosCaster1Input = s;

		Debug.Log("Caster1.txt: " + SmashBrosCaster1Input); // shows input in debug

		string path = "Assets/Games/SmashBros/Caster1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosCaster1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosCaster1Input);
	}

	public void SmashBrosCaster2(string s)
	{
		string SmashBrosCaster2Input = s;

		Debug.Log("Caster2.txt: " + SmashBrosCaster2Input); // shows input in debug

		string path = "Assets/Games/SmashBros/Caster2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosCaster2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosCaster2Input);
	}

	public void SmashBrosHomeGame1Toggle(bool tog)
	{
		SmashBrosHomeDDStringInput = SmashBrosHomeDDInput.options[SmashBrosHomeDDInput.value].text;
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + SmashBrosHomeDDStringInput + text2;
		string path = "Assets/Games/SmashBros/Game1 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 1 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/SmashBros/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 1 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/SmashBros/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (SmashBrosAwayDDStringInput == "SELECT TEAM")
		{
			File.Copy(sourceMapBlankFile, destMapFile, true);
			File.Copy(sourceLogoBlankFile, destLogoFile, true);
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				File.Copy(sourceMapPlayedFile, destMapFile, true);
				File.Copy(sourceLogoHomeFile, destLogoFile, true);
				Debug.Log(text1 + SmashBrosHomeDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				File.Copy(sourceMapBlankFile, destMapFile, true);
				File.Copy(sourceLogoBlankFile, destLogoFile, true);
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void SmashBrosHomeGame2Toggle(bool tog)
	{
		SmashBrosHomeDDStringInput = SmashBrosHomeDDInput.options[SmashBrosHomeDDInput.value].text;
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + SmashBrosHomeDDStringInput + text2;
		string path = "Assets/Games/SmashBros/Game2 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 2 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/SmashBros/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 2 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/SmashBros/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (SmashBrosAwayDDStringInput == "SELECT TEAM")
		{
			File.Copy(sourceMapBlankFile, destMapFile, true);
			File.Copy(sourceLogoBlankFile, destLogoFile, true);
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				File.Copy(sourceMapPlayedFile, destMapFile, true);
				File.Copy(sourceLogoHomeFile, destLogoFile, true);
				Debug.Log(text1 + SmashBrosHomeDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				File.Copy(sourceMapBlankFile, destMapFile, true);
				File.Copy(sourceLogoBlankFile, destLogoFile, true);
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void SmashBrosHomeGame3Toggle(bool tog)
	{
		SmashBrosHomeDDStringInput = SmashBrosHomeDDInput.options[SmashBrosHomeDDInput.value].text;
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + SmashBrosHomeDDStringInput + text2;
		string path = "Assets/Games/SmashBros/Game3 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 3 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/SmashBros/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 3 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/SmashBros/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (SmashBrosAwayDDStringInput == "SELECT TEAM")
		{
			File.Copy(sourceMapBlankFile, destMapFile, true);
			File.Copy(sourceLogoBlankFile, destLogoFile, true);
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				File.Copy(sourceMapPlayedFile, destMapFile, true);
				File.Copy(sourceLogoHomeFile, destLogoFile, true);
				Debug.Log(text1 + SmashBrosHomeDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				File.Copy(sourceMapBlankFile, destMapFile, true);
				File.Copy(sourceLogoBlankFile, destLogoFile, true);
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void SmashBrosGame1Score(string s)
	{
		string SmashBrosGame1ScoreInput = s;

		Debug.Log("Game1 Score.txt: " + SmashBrosGame1ScoreInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Game1 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosGame1ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosGame1ScoreInput);

	}

	public void SmashBrosGame2Score(string s)
	{
		string SmashBrosGame2ScoreInput = s;

		Debug.Log("Game2 Score.txt: " + SmashBrosGame2ScoreInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Game2 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosGame2ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosGame2ScoreInput);
	}

	public void SmashBrosGame3Score(string s)
	{
		string SmashBrosGame3ScoreInput = s;

		Debug.Log("Game3 Score.txt: " + SmashBrosGame3ScoreInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Game3 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosGame3ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosGame3ScoreInput);
	}

	public void SmashBrosGame4Score(string s)
	{
		string SmashBrosGame4ScoreInput = s;

		Debug.Log("Game4 Score.txt: " + SmashBrosGame4ScoreInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Game4 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosGame4ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosGame4ScoreInput);
	}

	public void SmashBrosGame5Score(string s)
	{
		string SmashBrosGame5ScoreInput = s;

		Debug.Log("Game5 Score.txt: " + SmashBrosGame5ScoreInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Game5 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosGame5ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosGame5ScoreInput);
	}

	public void SmashBrosAwayGame1Toggle(bool tog)
	{
		SmashBrosAwayDDStringInput = SmashBrosAwayDDInput.options[SmashBrosAwayDDInput.value].text;
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + SmashBrosAwayDDStringInput + text2;
		string path = "Assets/Games/SmashBros/Game1 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 1 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/SmashBros/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 1 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/SmashBros/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (SmashBrosAwayDDStringInput == "SELECT TEAM")
		{
			File.Copy(sourceMapBlankFile, destMapFile, true);
			File.Copy(sourceLogoBlankFile, destLogoFile, true);
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				File.Copy(sourceMapPlayedFile, destMapFile, true);
				File.Copy(sourceLogoAwayFile, destLogoFile, true);
				Debug.Log(text1 + SmashBrosAwayDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				File.Copy(sourceMapBlankFile, destMapFile, true);
				File.Copy(sourceLogoBlankFile, destLogoFile, true);
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void SmashBrosAwayGame2Toggle(bool tog)
	{
		SmashBrosAwayDDStringInput = SmashBrosAwayDDInput.options[SmashBrosAwayDDInput.value].text;
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + SmashBrosAwayDDStringInput + text2;
		string path = "Assets/Games/SmashBros/Game2 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 2 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/SmashBros/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 2 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/SmashBros/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (SmashBrosAwayDDStringInput == "SELECT TEAM")
		{
			File.Copy(sourceMapBlankFile, destMapFile, true);
			File.Copy(sourceLogoBlankFile, destLogoFile, true);
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				File.Copy(sourceMapPlayedFile, destMapFile, true);
				File.Copy(sourceLogoAwayFile, destLogoFile, true);
				Debug.Log(text1 + SmashBrosAwayDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				File.Copy(sourceMapBlankFile, destMapFile, true);
				File.Copy(sourceLogoBlankFile, destLogoFile, true);
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void SmashBrosAwayGame3Toggle(bool tog)
	{
		SmashBrosAwayDDStringInput = SmashBrosAwayDDInput.options[SmashBrosAwayDDInput.value].text;
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + SmashBrosAwayDDStringInput + text2;
		string path = "Assets/Games/SmashBros/Game3 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 3 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/SmashBros/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 3 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/SmashBros/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (SmashBrosAwayDDStringInput == "SELECT TEAM")
		{
			File.Copy(sourceMapBlankFile, destMapFile, true);
			File.Copy(sourceLogoBlankFile, destLogoFile, true);
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				File.Copy(sourceMapPlayedFile, destMapFile, true);
				File.Copy(sourceLogoAwayFile, destLogoFile, true);
				Debug.Log(text1 + SmashBrosAwayDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				File.Copy(sourceMapBlankFile, destMapFile, true);
				File.Copy(sourceLogoBlankFile, destLogoFile, true);
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void SmashBrosAwayGame4Toggle(bool tog)
	{
		SmashBrosAwayDDStringInput = SmashBrosAwayDDInput.options[SmashBrosAwayDDInput.value].text;
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + SmashBrosAwayDDStringInput + text2;
		string path = "Assets/Games/SmashBros/Game4 Winner.txt";


		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 4 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/SmashBros/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 4 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/SmashBros/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (SmashBrosAwayDDStringInput == "SELECT TEAM")
		{
			File.Copy(sourceMapBlankFile, destMapFile, true);
			File.Copy(sourceLogoBlankFile, destLogoFile, true);
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				File.Copy(sourceMapPlayedFile, destMapFile, true);
				File.Copy(sourceLogoAwayFile, destLogoFile, true);
				Debug.Log(text1 + SmashBrosAwayDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				File.Copy(sourceMapBlankFile, destMapFile, true);
				File.Copy(sourceLogoBlankFile, destLogoFile, true);
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void SmashBrosAwayGame5Toggle(bool tog)
	{
		SmashBrosAwayDDStringInput = SmashBrosAwayDDInput.options[SmashBrosAwayDDInput.value].text;
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + SmashBrosAwayDDStringInput + text2;
		string path = "Assets/Games/SmashBros/Game5 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 5 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/SmashBros/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 5 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/SmashBros/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (SmashBrosAwayDDStringInput == "SELECT TEAM")
		{
			File.Copy(sourceMapBlankFile, destMapFile, true);
			File.Copy(sourceLogoBlankFile, destLogoFile, true);
			File.WriteAllText(path, "");
		}

		else
		{
			if (tog == true)
			{
				File.Copy(sourceMapPlayedFile, destMapFile, true);
				File.Copy(sourceLogoAwayFile, destLogoFile, true);
				Debug.Log(text1 + SmashBrosAwayDDStringInput + text2);
				File.WriteAllText(path, bothinput);
			}

			if (tog == false)
			{
				File.Copy(sourceMapBlankFile, destMapFile, true);
				File.Copy(sourceLogoBlankFile, destLogoFile, true);
				Debug.Log(text1);
				File.WriteAllText(path, "");
			}
		}
	}

	public void SmashBrosHomeDDValue(Dropdown sender)
	{
		SmashBrosHomeDDStringInput = SmashBrosHomeDDInput.options[SmashBrosHomeDDInput.value].text;
		Debug.Log("Home Team Name.txt: " + SmashBrosHomeDDStringInput);

		string path = "Assets/Games/SmashBros/Home Team Name.txt"; // This is the directory for the text file.

		if (SmashBrosHomeDDStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoBlank);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (SmashBrosHomeDDStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoSR);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);
		}
		if (SmashBrosHomeDDStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoRIT);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (SmashBrosHomeDDStringInput == "UALBANY")

		{
			string logoUA = "UA Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoUA);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (SmashBrosHomeDDStringInput == "NYIT")

		{
			string logoNYIT = "NYIT Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoNYIT);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (SmashBrosHomeDDStringInput == "SPU")

		{
			string logoSPU = "SPU Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoSPU);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (SmashBrosHomeDDStringInput == "POLYTECHNIC")

		{
			string logoSP = "SP Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoSP);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (SmashBrosHomeDDStringInput != "SELECT TEAM")
		{
			File.WriteAllText(path, SmashBrosHomeDDStringInput); // sets the location to path and the contents to input
		}
	}

	public void SmashBrosHomeSeasonRecord(string s)
	{
		string SmashBrosHomeSeasonRecordInput = s;

		Debug.Log("Home Team Season Record.txt: " + SmashBrosHomeSeasonRecordInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Home Team Season Record.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosHomeSeasonRecordInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosHomeSeasonRecordInput);
	}

	public void SmashBrosHomeSeriesScoreIncrement()
	{
		string maxValue = "3";
		string path = "Assets/Games/SmashBros/Home Team Series Score.txt";
		if (SmashBrosHomeSeriesScoreInputField != null && SmashBrosHomeSeriesScoreInputField.text != maxValue)
		{
			++SmashBrosHomeSeriesScoreValue;
			SmashBrosHomeSeriesScoreInput = SmashBrosHomeSeriesScoreValue.ToString();
			SmashBrosHomeSeriesScoreInputField.text = SmashBrosHomeSeriesScoreValue.ToString();
			Debug.Log("Increment - Home Team Series Score.txt: " + SmashBrosHomeSeriesScoreInputField.text);
			File.WriteAllText(path, SmashBrosHomeSeriesScoreInputField.text);
		}
	}

	public void SmashBrosHomeSeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/SmashBros/Home Team Series Score.txt";
		if (SmashBrosHomeSeriesScoreInputField != null && SmashBrosHomeSeriesScoreInputField.text != minValue)
		{
			--SmashBrosHomeSeriesScoreValue;
			SmashBrosHomeSeriesScoreInput = SmashBrosHomeSeriesScoreValue.ToString();
			SmashBrosHomeSeriesScoreInputField.text = SmashBrosHomeSeriesScoreValue.ToString();
			Debug.Log("Decrement - Home Team Series Score.txt: " + SmashBrosHomeSeriesScoreInputField.text);
			File.WriteAllText(path, SmashBrosHomeSeriesScoreInputField.text);
		}
	}

	public void SmashBrosHomeSeriesScore(string s)
	{
		string path = "Assets/Games/SmashBros/Home Team Series Score.txt";
		SmashBrosHomeSeriesScoreInput = s;
		SmashBrosHomeSeriesScoreInput = SmashBrosHomeSeriesScoreValue.ToString();
		SmashBrosHomeSeriesScoreValue = Convert.ToInt32(SmashBrosHomeSeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Score.txt: " + SmashBrosHomeSeriesScoreValue);
		File.WriteAllText(path, SmashBrosHomeSeriesScoreInputField.text);
	}

	public void SmashBrosHomeStocksIncrement()
	{
		string maxValue = "9";
		string path = "Assets/Games/SmashBros/Home Team Stocks.txt";
		if (SmashBrosHomeSeriesScoreInputField != null && SmashBrosHomeSeriesScoreInputField.text != maxValue)
		{
			++SmashBrosHomeSeriesScoreValue;
			SmashBrosHomeSeriesScoreInput = SmashBrosHomeSeriesScoreValue.ToString();
			SmashBrosHomeSeriesScoreInputField.text = SmashBrosHomeSeriesScoreValue.ToString();
			Debug.Log("Increment - Home Team Stocks.txt: " + SmashBrosHomeSeriesScoreInputField.text);
			File.WriteAllText(path, SmashBrosHomeSeriesScoreInputField.text);
		}
	}

	public void SmashBrosHomeStocksDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/SmashBros/Home Team Stocks.txt";
		if (SmashBrosHomeSeriesScoreInputField != null && SmashBrosHomeSeriesScoreInputField.text != minValue)
		{
			--SmashBrosHomeSeriesScoreValue;
			SmashBrosHomeSeriesScoreInput = SmashBrosHomeSeriesScoreValue.ToString();
			SmashBrosHomeSeriesScoreInputField.text = SmashBrosHomeSeriesScoreValue.ToString();
			Debug.Log("Decrement - Home Team Stocks.txt: " + SmashBrosHomeSeriesScoreInputField.text);
			File.WriteAllText(path, SmashBrosHomeSeriesScoreInputField.text);
		}
	}

	public void SmashBrosHomeStocks(string s)
	{
		string path = "Assets/Games/SmashBros/Home Team Stocks.txt";
		SmashBrosHomeSeriesScoreInput = s;
		SmashBrosHomeSeriesScoreInput = SmashBrosHomeSeriesScoreValue.ToString();
		SmashBrosHomeSeriesScoreValue = Convert.ToInt32(SmashBrosHomeSeriesScoreInputField.text);
		Debug.Log("Input - Home Team Stocks.txt: " + SmashBrosHomeSeriesScoreValue);
		File.WriteAllText(path, SmashBrosHomeSeriesScoreInputField.text);
	}

	public void SmashBrosHomeActivePlayer1(bool tog)
	{
		string path = "Assets/Games/SmashBros/Home Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Home Team Active Player: " + SmashBrosHomePlayer1Input);
			File.WriteAllText(path, SmashBrosHomePlayer1Input);
		}
		else
		{
			Debug.Log("Home Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void SmashBrosHomeActivePlayer2(bool tog)
	{
		string path = "Assets/Games/SmashBros/Home Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Home Team Active Player: " + SmashBrosHomePlayer2Input);
			File.WriteAllText(path, SmashBrosHomePlayer2Input);
		}
		else
		{
			Debug.Log("Home Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void SmashBrosHomeActivePlayer3(bool tog)
	{
		string path = "Assets/Games/SmashBros/Home Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Home Team Active Player: " + SmashBrosHomePlayer3Input);
			File.WriteAllText(path, SmashBrosHomePlayer3Input);
		}
		else
		{
			Debug.Log("Home Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void SmashBrosHomePlayer1(string s)
	{
		SmashBrosHomePlayer1Input = s;

		Debug.Log("Home Team Player1.txt: " + SmashBrosHomePlayer1Input); // shows input in debug

		string path = "Assets/Games/SmashBros/Home Team Player1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosHomePlayer1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosHomePlayer1Input);
	}

	public void SmashBrosHomePlayer2(string s)
	{
		SmashBrosHomePlayer2Input = s;

		Debug.Log("Home Team Player2.txt: " + SmashBrosHomePlayer2Input); // shows input in debug

		string path = "Assets/Games/SmashBros/Home Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosHomePlayer2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosHomePlayer2Input);
	}

	public void SmashBrosHomePlayer3(string s)
	{
		SmashBrosHomePlayer3Input = s;

		Debug.Log("Home Team Player3.txt: " + SmashBrosHomePlayer3Input); // shows input in debug

		string path = "Assets/Games/SmashBros/Home Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosHomePlayer3Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosHomePlayer3Input);
	}

	public void SmashBrosHomePlayer1Stats(string s)
	{
		string SmashBrosHomePlayer1StatsInput = s;

		Debug.Log("Home Team Player1 Stats.txt: " + SmashBrosHomePlayer1StatsInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Home Team Player1 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosHomePlayer1StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosHomePlayer1StatsInput);
	}

	public void SmashBrosHomePlayer2Stats(string s)
	{
		string SmashBrosHomePlayer2StatsInput = s;

		Debug.Log("Home Team Player2 Stats.txt: " + SmashBrosHomePlayer2StatsInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Home Team Player2 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosHomePlayer2StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosHomePlayer2StatsInput);
	}

	public void SmashBrosHomePlayer3Stats(string s)
	{
		string SmashBrosHomePlayer3StatsInput = s;

		Debug.Log("Home Team Player3 Stats.txt: " + SmashBrosHomePlayer3StatsInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Home Team Player3 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosHomePlayer3StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosHomePlayer3StatsInput);
	}

	public void SmashBrosAwayDDValue(Dropdown sender)
	{
		SmashBrosAwayDDStringInput = SmashBrosAwayDDInput.options[SmashBrosAwayDDInput.value].text;
		Debug.Log("Away Team Name.txt: " + SmashBrosAwayDDStringInput);

		string path = "Assets/Games/SmashBros/Away Team Name.txt"; // This is the directory for the text file.

		if (SmashBrosAwayDDStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoBlank);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (SmashBrosAwayDDStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoSR);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);
		}
		if (SmashBrosAwayDDStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoRIT);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (SmashBrosAwayDDStringInput == "UALBANY")

		{
			string logoUA = "UA Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoUA);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (SmashBrosAwayDDStringInput == "NYIT")

		{
			string logoNYIT = "NYIT Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoNYIT);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}


		if (SmashBrosAwayDDStringInput == "SPU")

		{
			string logoSPU = "SPU Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoSPU);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}


		if (SmashBrosAwayDDStringInput == "POLYTECHNIC")

		{
			string logoSP = "SP Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/SmashBros/";

			string sourceFile = Path.Combine(sourcePath, logoSP);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (SmashBrosAwayDDStringInput != "SELECT TEAM")
		{
			File.WriteAllText(path, SmashBrosAwayDDStringInput); // sets the location to path and the contents to input
		}
	}

	public void SmashBrosAwaySeasonRecord(string s)
	{
		string SmashBrosAwaySeasonRecordInput = s;

		Debug.Log("Away Team Season Record.txt: " + SmashBrosAwaySeasonRecordInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Away Team Season Record.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosAwaySeasonRecordInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosAwaySeasonRecordInput);
	}

	public void SmashBrosAwaySeriesScoreIncrement()
	{
		string maxValue = "3";
		string path = "Assets/Games/SmashBros/Away Team Series Score.txt";
		if (SmashBrosAwaySeriesScoreInputField != null && SmashBrosAwaySeriesScoreInputField.text != maxValue)
		{
			++SmashBrosAwaySeriesScoreValue;
			SmashBrosAwaySeriesScoreInput = SmashBrosAwaySeriesScoreValue.ToString();
			SmashBrosAwaySeriesScoreInputField.text = SmashBrosAwaySeriesScoreValue.ToString();
			Debug.Log("Increment - Away Team Series Score.txt: " + SmashBrosAwaySeriesScoreInputField.text);
			File.WriteAllText(path, SmashBrosAwaySeriesScoreInputField.text);
		}
	}

	public void SmashBrosAwaySeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/SmashBros/Away Team Series Score.txt";
		if (SmashBrosAwaySeriesScoreInputField != null && SmashBrosAwaySeriesScoreInputField.text != minValue)
		{
			--SmashBrosAwaySeriesScoreValue;
			SmashBrosAwaySeriesScoreInput = SmashBrosAwaySeriesScoreValue.ToString();
			SmashBrosAwaySeriesScoreInputField.text = SmashBrosAwaySeriesScoreValue.ToString();
			Debug.Log("Decrement - Away Team Series Score.txt: " + SmashBrosAwaySeriesScoreInputField.text);
			File.WriteAllText(path, SmashBrosAwaySeriesScoreInputField.text);
		}
	}

	public void SmashBrosAwaySeriesScore(string s)
	{
		string path = "Assets/Games/SmashBros/Away Team Series Score.txt";
		SmashBrosAwaySeriesScoreInput = s;
		SmashBrosAwaySeriesScoreInput = SmashBrosAwaySeriesScoreValue.ToString();
		SmashBrosAwaySeriesScoreValue = Convert.ToInt32(SmashBrosAwaySeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Score.txt: " + SmashBrosAwaySeriesScoreValue);
		File.WriteAllText(path, SmashBrosAwaySeriesScoreInputField.text);
	}

	public void SmashBrosAwayStocksIncrement()
	{
		string maxValue = "9";
		string path = "Assets/Games/SmashBros/Away Team Stocks.txt";
		if (SmashBrosAwaySeriesScoreInputField != null && SmashBrosAwaySeriesScoreInputField.text != maxValue)
		{
			++SmashBrosAwaySeriesScoreValue;
			SmashBrosAwaySeriesScoreInput = SmashBrosAwaySeriesScoreValue.ToString();
			SmashBrosAwaySeriesScoreInputField.text = SmashBrosAwaySeriesScoreValue.ToString();
			Debug.Log("Increment - Away Team Stocks.txt: " + SmashBrosAwaySeriesScoreInputField.text);
			File.WriteAllText(path, SmashBrosAwaySeriesScoreInputField.text);
		}
	}

	public void SmashBrosAwayStocksDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/SmashBros/Away Team Stocks.txt";
		if (SmashBrosAwaySeriesScoreInputField != null && SmashBrosAwaySeriesScoreInputField.text != minValue)
		{
			--SmashBrosAwaySeriesScoreValue;
			SmashBrosAwaySeriesScoreInput = SmashBrosAwaySeriesScoreValue.ToString();
			SmashBrosAwaySeriesScoreInputField.text = SmashBrosAwaySeriesScoreValue.ToString();
			Debug.Log("Decrement - Away Team Stocks.txt: " + SmashBrosAwaySeriesScoreInputField.text);
			File.WriteAllText(path, SmashBrosAwaySeriesScoreInputField.text);
		}
	}

	public void SmashBrosAwayStocks(string s)
	{
		string path = "Assets/Games/SmashBros/Away Team Stocks.txt";
		SmashBrosAwaySeriesScoreInput = s;
		SmashBrosAwaySeriesScoreInput = SmashBrosAwaySeriesScoreValue.ToString();
		SmashBrosAwaySeriesScoreValue = Convert.ToInt32(SmashBrosAwaySeriesScoreInputField.text);
		Debug.Log("Input - Away Team Stocks.txt: " + SmashBrosHomeSeriesScoreValue);
		File.WriteAllText(path, SmashBrosAwaySeriesScoreInputField.text);
	}

	public void SmashBrosAwayActivePlayer1(bool tog)
	{
		string path = "Assets/Games/SmashBros/Away Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Away Team Active Player: " + SmashBrosAwayPlayer1Input);
			File.WriteAllText(path, SmashBrosAwayPlayer1Input);
		}
		else
		{
			Debug.Log("Away Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void SmashBrosAwayActivePlayer2(bool tog)
	{
		string path = "Assets/Games/SmashBros/Away Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Away Team Active Player: " + SmashBrosAwayPlayer2Input);
			File.WriteAllText(path, SmashBrosAwayPlayer2Input);
		}
		else
		{
			Debug.Log("Away Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void SmashBrosAwayActivePlayer3(bool tog)
	{
		string path = "Assets/Games/SmashBros/Away Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Away Team Active Player: " + SmashBrosAwayPlayer3Input);
			File.WriteAllText(path, SmashBrosAwayPlayer3Input);
		}
		else
		{
			Debug.Log("Away Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void SmashBrosAwayPlayer1(string s)
	{
		SmashBrosAwayPlayer1Input = s;

		Debug.Log("Away Team Player1.txt: " + SmashBrosAwayPlayer1Input); // shows input in debug

		string path = "Assets/Games/SmashBros/Away Team Player1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosAwayPlayer1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosAwayPlayer1Input);
	}

	public void SmashBrosAwayPlayer2(string s)
	{
		SmashBrosAwayPlayer2Input = s;

		Debug.Log("Away Team Player2.txt: " + SmashBrosAwayPlayer2Input); // shows input in debug

		string path = "Assets/Games/SmashBros/Away Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosAwayPlayer2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosAwayPlayer2Input);
	}

	public void SmashBrosAwayPlayer3(string s)
	{
		SmashBrosAwayPlayer3Input = s;

		Debug.Log("Away Team Player3.txt: " + SmashBrosAwayPlayer3Input); // shows input in debug

		string path = "Assets/Games/SmashBros/Away Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosAwayPlayer3Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosAwayPlayer3Input);
	}

	public void SmashBrosAwayPlayer1Stats(string s)
	{
		string SmashBrosAwayPlayer1StatsInput = s;

		Debug.Log("Away Team Player1 Stats.txt: " + SmashBrosAwayPlayer1StatsInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Away Team Player1 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosAwayPlayer1StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosAwayPlayer1StatsInput);
	}

	public void SmashBrosAwayPlayer2Stats(string s)
	{
		string SmashBrosAwayPlayer2StatsInput = s;

		Debug.Log("Away Team Player2 Stats.txt: " + SmashBrosAwayPlayer2StatsInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Away Team Player2 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosAwayPlayer2StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosAwayPlayer2StatsInput);
	}

	public void SmashBrosAwayPlayer3Stats(string s)
	{
		string SmashBrosAwayPlayer3StatsInput = s;

		Debug.Log("Away Team Player3 Stats.txt: " + SmashBrosAwayPlayer3StatsInput); // shows input in debug

		string path = "Assets/Games/SmashBros/Away Team Player3 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, SmashBrosAwayPlayer3StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, SmashBrosAwayPlayer3StatsInput);
	}

}
