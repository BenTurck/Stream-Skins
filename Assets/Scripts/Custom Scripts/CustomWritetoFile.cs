using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Amazon.DynamoDBv2;

public class CustomWritetoFile : MonoBehaviour
{
	private string CustomHomeNameStringInput;

	public string CustomHomeSeriesScoreInput;

	public InputField CustomHomeSeriesScoreInputField;

	public int CustomHomeSeriesScoreValue = 0;

	private string CustomHomePlayer1Input;

	private string CustomHomePlayer2Input;

	private string CustomHomePlayer3Input;

	private string CustomHomePlayer4Input;

	private string CustomHomePlayer5Input;

	private string CustomHomePlayer6Input;

	private string CustomAwayNameStringInput;

	public string CustomAwaySeriesScoreInput;

	public InputField CustomAwaySeriesScoreInputField;

	public int CustomAwaySeriesScoreValue = 0;

	private string CustomAwayPlayer1Input;

	private string CustomAwayPlayer2Input;

	private string CustomAwayPlayer3Input;

	private string CustomAwayPlayer4Input;

	private string CustomAwayPlayer5Input;

	private string CustomAwayPlayer6Input;




	//Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void CustomTicker(string s)
	{
		string CustomTickerInput = s;

		Debug.Log("Ticker.txt: " + CustomTickerInput); // shows input in debug

		string path = "Assets/Games/Custom/Ticker.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomTickerInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomTickerInput);
	}

	public void CustomCaster1(string s)
	{
		string CustomCaster1Input = s;

		Debug.Log("Caster1.txt: " + CustomCaster1Input); // shows input in debug

		string path = "Assets/Games/Custom/Caster1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomCaster1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomCaster1Input);
	}

	public void CustomCaster2(string s)
	{
		string CustomCaster2Input = s;

		Debug.Log("Caster2.txt: " + CustomCaster2Input); // shows input in debug

		string path = "Assets/Games/Custom/Caster2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomCaster2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomCaster2Input);
	}

	public void CustomGame1Name(string s)
	{
		string CustomGame1NameInput = s;

		Debug.Log("Map1 Name.txt: " + CustomGame1NameInput); // shows input in debug

		string path = "Assets/Games/Custom/Map1 Name.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomGame1NameInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomGame1NameInput);

	}

	public void CustomGame2Name(string s)
	{
		string CustomGame2NameInput = s;

		Debug.Log("Map2 Name.txt: " + CustomGame2NameInput); // shows input in debug

		string path = "Assets/Games/Custom/Map2 Name.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomGame2NameInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomGame2NameInput);

	}

	public void CustomGame3Name(string s)
	{
		string CustomGame3NameInput = s;

		Debug.Log("Map3 Name.txt: " + CustomGame3NameInput); // shows input in debug

		string path = "Assets/Games/Custom/Map3 Name.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomGame3NameInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomGame3NameInput);

	}

	public void CustomGame4Name(string s)
	{
		string CustomGame4NameInput = s;

		Debug.Log("Map4 Name.txt: " + CustomGame4NameInput); // shows input in debug

		string path = "Assets/Games/Custom/Map4 Name.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomGame4NameInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomGame4NameInput);

	}

	public void CustomGame5Name(string s)
	{
		string CustomGame5NameInput = s;

		Debug.Log("Map5 Name.txt: " + CustomGame5NameInput); // shows input in debug

		string path = "Assets/Games/Custom/Map5 Name.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomGame5NameInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomGame5NameInput);

	}

	public void CustomHomeGame1Toggle(bool tog)
	{
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + CustomHomeNameStringInput + text2;
		string path = "Assets/Games/Custom/Game1 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 1 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Custom/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 1 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Custom/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (CustomHomeNameStringInput == "")
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
				Debug.Log(text1 + CustomHomeNameStringInput + text2);
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

	public void CustomHomeGame2Toggle(bool tog)
	{
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + CustomHomeNameStringInput + text2;
		string path = "Assets/Games/Custom/Game2 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 2 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Custom/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 2 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Custom/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (CustomHomeNameStringInput == "")
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
				Debug.Log(text1 + CustomHomeNameStringInput + text2);
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

	public void CustomHomeGame3Toggle(bool tog)
	{
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + CustomHomeNameStringInput + text2;
		string path = "Assets/Games/Custom/Game3 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 3 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Custom/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 3 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Custom/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (CustomHomeNameStringInput == "")
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
				Debug.Log(text1 + CustomHomeNameStringInput + text2);
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

	public void CustomHomeGame4Toggle(bool tog)
	{
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + CustomHomeNameStringInput + text2;
		string path = "Assets/Games/Custom/Game4 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 4 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Custom/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 4 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Custom/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (CustomHomeNameStringInput == "")
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
				Debug.Log(text1 + CustomHomeNameStringInput + text2);
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

	public void CustomHomeGame5Toggle(bool tog)
	{
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + CustomHomeNameStringInput + text2;
		string path = "Assets/Games/Custom/Game5 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 5 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Custom/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 5 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Custom/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (CustomHomeNameStringInput == "")
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
				Debug.Log(text1 + CustomHomeNameStringInput + text2);
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

	public void CustomGame1Score(string s)
	{
		string CustomGame1ScoreInput = s;

		Debug.Log("Game1 Score.txt: " + CustomGame1ScoreInput); // shows input in debug

		string path = "Assets/Games/Custom/Game1 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomGame1ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomGame1ScoreInput);

	}

	public void CustomGame2Score(string s)
	{
		string CustomGame2ScoreInput = s;

		Debug.Log("Game2 Score.txt: " + CustomGame2ScoreInput); // shows input in debug

		string path = "Assets/Games/Custom/Game2 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomGame2ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomGame2ScoreInput);
	}

	public void CustomGame3Score(string s)
	{
		string CustomGame3ScoreInput = s;

		Debug.Log("Game3 Score.txt: " + CustomGame3ScoreInput); // shows input in debug

		string path = "Assets/Games/Custom/Game3 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomGame3ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomGame3ScoreInput);
	}

	public void CustomGame4Score(string s)
	{
		string CustomGame4ScoreInput = s;

		Debug.Log("Game4 Score.txt: " + CustomGame4ScoreInput); // shows input in debug

		string path = "Assets/Games/Custom/Game4 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomGame4ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomGame4ScoreInput);
	}

	public void CustomGame5Score(string s)
	{
		string CustomGame5ScoreInput = s;

		Debug.Log("Game5 Score.txt: " + CustomGame5ScoreInput); // shows input in debug

		string path = "Assets/Games/Custom/Game5 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomGame5ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomGame5ScoreInput);
	}

	public void CustomAwayGame1Toggle(bool tog)
	{
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + CustomAwayNameStringInput + text2;
		string path = "Assets/Games/Custom/Game1 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 1 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Custom/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 1 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Custom/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (CustomAwayNameStringInput == "")
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
				Debug.Log(text1 + CustomAwayNameStringInput + text2);
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

	public void CustomAwayGame2Toggle(bool tog)
	{
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + CustomAwayNameStringInput + text2;
		string path = "Assets/Games/Custom/Game2 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 2 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Custom/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 2 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Custom/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (CustomAwayNameStringInput == "")
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
				Debug.Log(text1 + CustomAwayNameStringInput + text2);
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

	public void CustomAwayGame3Toggle(bool tog)
	{
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + CustomAwayNameStringInput + text2;
		string path = "Assets/Games/Custom/Game3 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 3 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Custom/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 3 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Custom/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (CustomAwayNameStringInput == "")
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
				Debug.Log(text1 + CustomAwayNameStringInput + text2);
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

	public void CustomAwayGame4Toggle(bool tog)
	{
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + CustomAwayNameStringInput + text2;
		string path = "Assets/Games/Custom/Game4 Winner.txt";


		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 4 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Custom/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 4 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Custom/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (CustomAwayNameStringInput == "")
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
				Debug.Log(text1 + CustomAwayNameStringInput + text2);
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

	public void CustomAwayGame5Toggle(bool tog)
	{
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + CustomAwayNameStringInput + text2;
		string path = "Assets/Games/Custom/Game5 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 5 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Custom/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 5 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Custom/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (CustomAwayNameStringInput == "")
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
				Debug.Log(text1 + CustomAwayNameStringInput + text2);
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

	public void CustomHomeNameInput(string s)
	{
		CustomHomeNameStringInput = s;

		Debug.Log("Home Team Name.txt: " + CustomHomeNameStringInput); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Name.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomeNameStringInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomeNameStringInput);

		if (CustomHomeNameStringInput == "")
		{
			string logoBlank = "Blank.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Custom/";

			string sourceFile = Path.Combine(sourcePath, logoBlank);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (CustomHomeNameStringInput != "")
		{
			string logoCustom = "Custom1 Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Custom/";

			string sourceFile = Path.Combine(sourcePath, logoCustom);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, CustomHomeNameStringInput); // sets the location to path and the contents to input
		}

	}

	public void CustomHomeSeasonRecord(string s)
	{
		string CustomHomeSeasonRecordInput = s;

		Debug.Log("Home Team Season Record.txt: " + CustomHomeSeasonRecordInput); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Season Record.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomeSeasonRecordInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomeSeasonRecordInput);
	}

	public void CustomHomeSeriesScoreIncrement()
	{
		string maxValue = "3";
		string path = "Assets/Games/Custom/Home Team Series Score.txt";
		if (CustomHomeSeriesScoreInputField != null && CustomHomeSeriesScoreInputField.text != maxValue)
		{
			++CustomHomeSeriesScoreValue;
			CustomHomeSeriesScoreInput = CustomHomeSeriesScoreValue.ToString();
			CustomHomeSeriesScoreInputField.text = CustomHomeSeriesScoreValue.ToString();
			Debug.Log("Increment - Home Team Series Score.txt: " + CustomHomeSeriesScoreInputField.text);
			File.WriteAllText(path, CustomHomeSeriesScoreInputField.text);
		}
	}

	public void CustomHomeSeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/Custom/Home Team Series Score.txt";
		if (CustomHomeSeriesScoreInputField != null && CustomHomeSeriesScoreInputField.text != minValue)
		{
			--CustomHomeSeriesScoreValue;
			CustomHomeSeriesScoreInput = CustomHomeSeriesScoreValue.ToString();
			CustomHomeSeriesScoreInputField.text = CustomHomeSeriesScoreValue.ToString();
			Debug.Log("Decrement - Home Team Series Score.txt: " + CustomHomeSeriesScoreInputField.text);
			File.WriteAllText(path, CustomHomeSeriesScoreInputField.text);
		}
	}

	public void CustomHomeSeriesScore(string s)
	{
		string path = "Assets/Games/Custom/Home Team Series Score.txt";
		CustomHomeSeriesScoreInput = s;
		CustomHomeSeriesScoreInput = CustomHomeSeriesScoreValue.ToString();
		CustomHomeSeriesScoreValue = Convert.ToInt32(CustomHomeSeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Score.txt: " + CustomHomeSeriesScoreValue);
		File.WriteAllText(path, CustomHomeSeriesScoreInputField.text);
	}

	public void CustomHomeActivePlayer1(bool tog)
	{
		string path = "Assets/Games/Custom/Home Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Home Team Active Player: " + CustomHomePlayer1Input);
			File.WriteAllText(path, CustomHomePlayer1Input);
		}
		else
		{
			Debug.Log("Home Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomHomeActivePlayer2(bool tog)
	{
		string path = "Assets/Games/Custom/Home Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Home Team Active Player: " + CustomHomePlayer2Input);
			File.WriteAllText(path, CustomHomePlayer2Input);
		}
		else
		{
			Debug.Log("Home Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomHomeActivePlayer3(bool tog)
	{
		string path = "Assets/Games/Custom/Home Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Home Team Active Player: " + CustomHomePlayer3Input);
			File.WriteAllText(path, CustomHomePlayer3Input);
		}
		else
		{
			Debug.Log("Home Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomHomeActivePlayer4(bool tog)
	{
		string path = "Assets/Games/Custom/Home Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Home Team Active Player: " + CustomHomePlayer4Input);
			File.WriteAllText(path, CustomHomePlayer4Input);
		}
		else
		{
			Debug.Log("Home Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomHomeActivePlayer5(bool tog)
	{
		string path = "Assets/Games/Custom/Home Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Home Team Active Player: " + CustomHomePlayer5Input);
			File.WriteAllText(path, CustomHomePlayer5Input);
		}
		else
		{
			Debug.Log("Home Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomHomeActivePlayer6(bool tog)
	{
		string path = "Assets/Games/Custom/Home Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Home Team Active Player: " + CustomHomePlayer6Input);
			File.WriteAllText(path, CustomHomePlayer6Input);
		}
		else
		{
			Debug.Log("Home Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomHomePlayer1(string s)
	{
		CustomHomePlayer1Input = s;

		Debug.Log("Home Team Player1.txt: " + CustomHomePlayer1Input); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer1Input);
	}

	public void CustomHomePlayer2(string s)
	{
		CustomHomePlayer2Input = s;

		Debug.Log("Home Team Player2.txt: " + CustomHomePlayer2Input); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer2Input);
	}

	public void CustomHomePlayer3(string s)
	{
		CustomHomePlayer3Input = s;

		Debug.Log("Home Team Player3.txt: " + CustomHomePlayer3Input); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer3Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer3Input);
	}

	public void CustomHomePlayer4(string s)
	{
		CustomHomePlayer4Input = s;

		Debug.Log("Home Team Player4.txt: " + CustomHomePlayer4Input); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player4.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer4Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer4Input);
	}

	public void CustomHomePlayer5(string s)
	{
		CustomHomePlayer5Input = s;

		Debug.Log("Home Team Player5.txt: " + CustomHomePlayer5Input); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer5Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer5Input);
	}

	public void CustomHomePlayer6(string s)
	{
		CustomHomePlayer6Input = s;

		Debug.Log("Home Team Player6.txt: " + CustomHomePlayer6Input); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player6.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer6Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer6Input);
	}

	public void CustomHomePlayer1Stats(string s)
	{
		string CustomHomePlayer1StatsInput = s;

		Debug.Log("Home Team Player1 Stats.txt: " + CustomHomePlayer1StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player1 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer1StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer1StatsInput);
	}

	public void CustomHomePlayer2Stats(string s)
	{
		string CustomHomePlayer2StatsInput = s;

		Debug.Log("Home Team Player2 Stats.txt: " + CustomHomePlayer2StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player2 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer2StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer2StatsInput);
	}

	public void CustomHomePlayer3Stats(string s)
	{
		string CustomHomePlayer3StatsInput = s;

		Debug.Log("Home Team Player3 Stats.txt: " + CustomHomePlayer3StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player3 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer3StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer3StatsInput);
	}

	public void CustomHomePlayer4Stats(string s)
	{
		string CustomHomePlayer4StatsInput = s;

		Debug.Log("Home Team Player4 Stats.txt: " + CustomHomePlayer4StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player4 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer4StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer4StatsInput);
	}

	public void CustomHomePlayer5Stats(string s)
	{
		string CustomHomePlayer5StatsInput = s;

		Debug.Log("Home Team Player5 Stats.txt: " + CustomHomePlayer5StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player5 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer5StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer5StatsInput);
	}

	public void CustomHomePlayer6Stats(string s)
	{
		string CustomHomePlayer6StatsInput = s;

		Debug.Log("Home Team Player6 Stats.txt: " + CustomHomePlayer6StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Home Team Player6 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer6StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer6StatsInput);
	}

	public void CustomAwayNameInput(string s)
	{
		CustomAwayNameStringInput = s;

		Debug.Log("Away Team Name.txt: " + CustomAwayNameStringInput); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Name.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomAwayNameStringInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomAwayNameStringInput);

		if (CustomAwayNameStringInput == "")
		{
			string logoBlank = "Blank.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Custom/";

			string sourceFile = Path.Combine(sourcePath, logoBlank);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (CustomAwayNameStringInput != "")
		{
			string logoCustom = "Custom2 Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Custom/";

			string sourceFile = Path.Combine(sourcePath, logoCustom);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, CustomAwayNameStringInput); // sets the location to path and the contents to input
		}
	}

	public void CustomAwaySeasonRecord(string s)
	{
		string CustomAwaySeasonRecordInput = s;

		Debug.Log("Away Team Season Record.txt: " + CustomAwaySeasonRecordInput); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Season Record.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomAwaySeasonRecordInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomAwaySeasonRecordInput);
	}

	public void CustomAwaySeriesScoreIncrement()
	{
		string maxValue = "3";
		string path = "Assets/Games/Custom/Away Team Series Score.txt";
		if (CustomAwaySeriesScoreInputField != null && CustomAwaySeriesScoreInputField.text != maxValue)
		{
			++CustomAwaySeriesScoreValue;
			CustomAwaySeriesScoreInput = CustomAwaySeriesScoreValue.ToString();
			CustomAwaySeriesScoreInputField.text = CustomAwaySeriesScoreValue.ToString();
			Debug.Log("Increment - Away Team Series Score.txt: " + CustomAwaySeriesScoreInputField.text);
			File.WriteAllText(path, CustomAwaySeriesScoreInputField.text);
		}
	}

	public void CustomAwaySeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/Custom/Away Team Series Score.txt";
		if (CustomAwaySeriesScoreInputField != null && CustomAwaySeriesScoreInputField.text != minValue)
		{
			--CustomAwaySeriesScoreValue;
			CustomAwaySeriesScoreInput = CustomAwaySeriesScoreValue.ToString();
			CustomAwaySeriesScoreInputField.text = CustomAwaySeriesScoreValue.ToString();
			Debug.Log("Decrement - Away Team Series Score.txt: " + CustomAwaySeriesScoreInputField.text);
			File.WriteAllText(path, CustomAwaySeriesScoreInputField.text);
		}
	}

	public void CustomAwaySeriesScore(string s)
	{
		string path = "Assets/Games/Custom/Away Team Series Score.txt";
		CustomAwaySeriesScoreInput = s;
		CustomAwaySeriesScoreInput = CustomAwaySeriesScoreValue.ToString();
		CustomAwaySeriesScoreValue = Convert.ToInt32(CustomAwaySeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Score.txt: " + CustomAwaySeriesScoreValue);
		File.WriteAllText(path, CustomAwaySeriesScoreInputField.text);
	}

	public void CustomAwayActivePlayer1(bool tog)
	{
		string path = "Assets/Games/Custom/Away Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Away Team Active Player: " + CustomAwayPlayer1Input);
			File.WriteAllText(path, CustomAwayPlayer1Input);
		}
		else
		{
			Debug.Log("Away Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomAwayActivePlayer2(bool tog)
	{
		string path = "Assets/Games/Custom/Away Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Away Team Active Player: " + CustomAwayPlayer2Input);
			File.WriteAllText(path, CustomAwayPlayer2Input);
		}
		else
		{
			Debug.Log("Away Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomAwayActivePlayer3(bool tog)
	{
		string path = "Assets/Games/Custom/Away Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Away Team Active Player: " + CustomAwayPlayer3Input);
			File.WriteAllText(path, CustomAwayPlayer3Input);
		}
		else
		{
			Debug.Log("Away Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomAwayActivePlayer4(bool tog)
	{
		string path = "Assets/Games/Custom/Away Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Away Team Active Player: " + CustomAwayPlayer4Input);
			File.WriteAllText(path, CustomAwayPlayer4Input);
		}
		else
		{
			Debug.Log("Away Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomAwayActivePlayer5(bool tog)
	{
		string path = "Assets/Games/Custom/Away Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Away Team Active Player: " + CustomAwayPlayer5Input);
			File.WriteAllText(path, CustomAwayPlayer5Input);
		}
		else
		{
			Debug.Log("Away Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomAwayActivePlayer6(bool tog)
	{
		string path = "Assets/Games/Custom/Away Team Active Player.txt";
		if (tog == true)
		{
			Debug.Log("Away Team Active Player: " + CustomAwayPlayer6Input);
			File.WriteAllText(path, CustomAwayPlayer6Input);
		}
		else
		{
			Debug.Log("Away Team Active Player: ");
			File.WriteAllText(path, "");
		}
	}

	public void CustomAwayPlayer1(string s)
	{
		CustomAwayPlayer1Input = s;

		Debug.Log("Away Team Player1.txt: " + CustomAwayPlayer1Input); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomAwayPlayer1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomAwayPlayer1Input);
	}

	public void CustomAwayPlayer2(string s)
	{
		CustomAwayPlayer2Input = s;

		Debug.Log("Away Team Player2.txt: " + CustomAwayPlayer2Input); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomAwayPlayer2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomAwayPlayer2Input);
	}

	public void CustomAwayPlayer3(string s)
	{
		CustomAwayPlayer3Input = s;

		Debug.Log("Away Team Player3.txt: " + CustomAwayPlayer3Input); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomAwayPlayer3Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomAwayPlayer3Input);
	}

	public void CustomAwayPlayer4(string s)
	{
		CustomAwayPlayer4Input = s;

		Debug.Log("Away Team Player4.txt: " + CustomAwayPlayer4Input); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player4.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomAwayPlayer4Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomAwayPlayer4Input);
	}

	public void CustomAwayPlayer5(string s)
	{
		CustomHomePlayer5Input = s;

		Debug.Log("Away Team Player5.txt: " + CustomHomePlayer5Input); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer5Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer5Input);
	}

	public void CustomAwayPlayer6(string s)
	{
		CustomHomePlayer6Input = s;

		Debug.Log("Away Team Player6.txt: " + CustomHomePlayer6Input); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player6.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer6Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer6Input);
	}

	public void CustomAwayPlayer1Stats(string s)
	{
		string CustomAwayPlayer1StatsInput = s;

		Debug.Log("Away Team Player1 Stats.txt: " + CustomAwayPlayer1StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player1 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomAwayPlayer1StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomAwayPlayer1StatsInput);
	}

	public void CustomAwayPlayer2Stats(string s)
	{
		string CustomAwayPlayer2StatsInput = s;

		Debug.Log("Away Team Player2 Stats.txt: " + CustomAwayPlayer2StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player2 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomAwayPlayer2StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomAwayPlayer2StatsInput);
	}

	public void CustomAwayPlayer3Stats(string s)
	{
		string CustomAwayPlayer3StatsInput = s;

		Debug.Log("Away Team Player3 Stats.txt: " + CustomAwayPlayer3StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player3 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomAwayPlayer3StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomAwayPlayer3StatsInput);
	}

	public void CustomAwayPlayer4Stats(string s)
	{
		string CustomAwayPlayer4StatsInput = s;

		Debug.Log("Away Team Player4 Stats.txt: " + CustomAwayPlayer4StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player4 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomAwayPlayer4StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomAwayPlayer4StatsInput);
	}

	public void CustomAwayPlayer5Stats(string s)
	{
		string CustomHomePlayer5StatsInput = s;

		Debug.Log("Away Team Player5 Stats.txt: " + CustomHomePlayer5StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player5 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer5StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer5StatsInput);
	}

	public void CustomAwayPlayer6Stats(string s)
	{
		string CustomHomePlayer6StatsInput = s;

		Debug.Log("Away Team Player5 Stats.txt: " + CustomHomePlayer6StatsInput); // shows input in debug

		string path = "Assets/Games/Custom/Away Team Player6 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, CustomHomePlayer6StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, CustomHomePlayer6StatsInput);
	}

}
