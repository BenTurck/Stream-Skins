using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Amazon.DynamoDBv2;

public class LeagueofLegendsWritetoFile : MonoBehaviour
{
	public Dropdown LeagueofLegendsHomeDDInput;

	private string LeagueofLegendsHomeDDStringInput;

	public string LeagueofLegendsHomeSeriesScoreInput;

	public InputField LeagueofLegendsHomeSeriesScoreInputField;

	public int LeagueofLegendsHomeSeriesScoreValue = 0;

	public Dropdown LeagueofLegendsAwayDDInput;

	private string LeagueofLegendsAwayDDStringInput;

	public string LeagueofLegendsAwaySeriesScoreInput;

	public InputField LeagueofLegendsAwaySeriesScoreInputField;

	public int LeagueofLegendsAwaySeriesScoreValue = 0;




	//Start is called before the first frame update
	void Start()
	{
		LeagueofLegendsHomeDDInput.onValueChanged.AddListener(delegate
		{
			LeagueofLegendsHomeDDValue(LeagueofLegendsHomeDDInput);

		});

		LeagueofLegendsAwayDDInput.onValueChanged.AddListener(delegate
		{
			LeagueofLegendsAwayDDValue(LeagueofLegendsAwayDDInput);

		});
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void LeagueofLegendsTicker(string s)
	{
		string LeagueofLegendsTickerInput = s;

		Debug.Log("Ticker.txt: " + LeagueofLegendsTickerInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Ticker.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsTickerInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsTickerInput);
	}

	public void LeagueofLegendsCaster1(string s)
	{
		string LeagueofLegendsCaster1Input = s;

		Debug.Log("Caster1.txt: " + LeagueofLegendsCaster1Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Caster1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsCaster1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsCaster1Input);
	}

	public void LeagueofLegendsCaster2(string s)
	{
		string LeagueofLegendsCaster2Input = s;

		Debug.Log("Caster2.txt: " + LeagueofLegendsCaster2Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Caster2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsCaster2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsCaster2Input);
	}

	public void LeagueofLegendsHomeGame1Toggle(bool tog)
	{
		LeagueofLegendsHomeDDStringInput = LeagueofLegendsHomeDDInput.options[LeagueofLegendsHomeDDInput.value].text;
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + LeagueofLegendsHomeDDStringInput + text2;
		string path = "Assets/Games/LeagueofLegends/Game1 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 1 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/LeagueofLegends/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 1 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/LeagueofLegends/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + LeagueofLegendsHomeDDStringInput + text2);
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

	public void LeagueofLegendsHomeGame2Toggle(bool tog)
	{
		LeagueofLegendsHomeDDStringInput = LeagueofLegendsHomeDDInput.options[LeagueofLegendsHomeDDInput.value].text;
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + LeagueofLegendsHomeDDStringInput + text2;
		string path = "Assets/Games/LeagueofLegends/Game2 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 2 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/LeagueofLegends/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 2 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/LeagueofLegends/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + LeagueofLegendsHomeDDStringInput + text2);
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

	public void LeagueofLegendsHomeGame3Toggle(bool tog)
	{
		LeagueofLegendsHomeDDStringInput = LeagueofLegendsHomeDDInput.options[LeagueofLegendsHomeDDInput.value].text;
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + LeagueofLegendsHomeDDStringInput + text2;
		string path = "Assets/Games/LeagueofLegends/Game3 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 3 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/LeagueofLegends/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 3 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/LeagueofLegends/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + LeagueofLegendsHomeDDStringInput + text2);
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

	public void LeagueofLegendsHomeGame4Toggle(bool tog)
	{
		LeagueofLegendsHomeDDStringInput = LeagueofLegendsHomeDDInput.options[LeagueofLegendsHomeDDInput.value].text;
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + LeagueofLegendsHomeDDStringInput + text2;
		string path = "Assets/Games/LeagueofLegends/Game4 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 4 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/LeagueofLegends/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 4 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/LeagueofLegends/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + LeagueofLegendsHomeDDStringInput + text2);
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

	public void LeagueofLegendsHomeGame5Toggle(bool tog)
	{
		LeagueofLegendsHomeDDStringInput = LeagueofLegendsHomeDDInput.options[LeagueofLegendsHomeDDInput.value].text;
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + LeagueofLegendsHomeDDStringInput + text2;
		string path = "Assets/Games/LeagueofLegends/Game5 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 5 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/LeagueofLegends/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 5 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/LeagueofLegends/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + LeagueofLegendsHomeDDStringInput + text2);
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

	public void LeagueofLegendsAwayGame1Toggle(bool tog)
	{
		LeagueofLegendsAwayDDStringInput = LeagueofLegendsAwayDDInput.options[LeagueofLegendsAwayDDInput.value].text;
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + LeagueofLegendsAwayDDStringInput + text2;
		string path = "Assets/Games/LeagueofLegends/Game1 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 1 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/LeagueofLegends/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 1 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/LeagueofLegends/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + LeagueofLegendsAwayDDStringInput + text2);
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

	public void LeagueofLegendsAwayGame2Toggle(bool tog)
	{
		LeagueofLegendsAwayDDStringInput = LeagueofLegendsAwayDDInput.options[LeagueofLegendsAwayDDInput.value].text;
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + LeagueofLegendsAwayDDStringInput + text2;
		string path = "Assets/Games/LeagueofLegends/Game2 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 2 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/LeagueofLegends/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 2 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/LeagueofLegends/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + LeagueofLegendsAwayDDStringInput + text2);
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

	public void LeagueofLegendsAwayGame3Toggle(bool tog)
	{
		LeagueofLegendsAwayDDStringInput = LeagueofLegendsAwayDDInput.options[LeagueofLegendsAwayDDInput.value].text;
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + LeagueofLegendsAwayDDStringInput + text2;
		string path = "Assets/Games/LeagueofLegends/Game3 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 3 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/LeagueofLegends/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 3 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/LeagueofLegends/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + LeagueofLegendsAwayDDStringInput + text2);
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

	public void LeagueofLegendsAwayGame4Toggle(bool tog)
	{
		LeagueofLegendsAwayDDStringInput = LeagueofLegendsAwayDDInput.options[LeagueofLegendsAwayDDInput.value].text;
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + LeagueofLegendsAwayDDStringInput + text2;
		string path = "Assets/Games/LeagueofLegends/Game4 Winner.txt";


		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 4 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/LeagueofLegends/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 4 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/LeagueofLegends/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + LeagueofLegendsAwayDDStringInput + text2);
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

	public void LeagueofLegendsAwayGame5Toggle(bool tog)
	{
		LeagueofLegendsAwayDDStringInput = LeagueofLegendsAwayDDInput.options[LeagueofLegendsAwayDDInput.value].text;
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + LeagueofLegendsAwayDDStringInput + text2;
		string path = "Assets/Games/LeagueofLegends/Game5 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 5 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/LeagueofLegends/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 5 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/LeagueofLegends/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + LeagueofLegendsAwayDDStringInput + text2);
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

	public void LeagueofLegendsHomeDDValue(Dropdown sender)
	{
		LeagueofLegendsHomeDDStringInput = LeagueofLegendsHomeDDInput.options[LeagueofLegendsHomeDDInput.value].text;
		Debug.Log("Home Team Name.txt: " + LeagueofLegendsHomeDDStringInput);

		string path = "Assets/Games/LeagueofLegends/Home Team Name.txt"; // This is the directory for the text file.

		if (LeagueofLegendsHomeDDStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoBlank);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (LeagueofLegendsHomeDDStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoSR);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);
		}
		if (LeagueofLegendsHomeDDStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoRIT);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (LeagueofLegendsHomeDDStringInput == "UALBANY")

		{
			string logoUA = "UA Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoUA);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (LeagueofLegendsHomeDDStringInput == "NYIT")

		{
			string logoNYIT = "NYIT Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoNYIT);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (LeagueofLegendsHomeDDStringInput == "SPU")

		{
			string logoSPU = "SPU Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoSPU);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (LeagueofLegendsHomeDDStringInput == "POLYTECHNIC")

		{
			string logoSP = "SP Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoSP);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (LeagueofLegendsHomeDDStringInput != "SELECT TEAM")
		{
			File.WriteAllText(path, LeagueofLegendsHomeDDStringInput); // sets the location to path and the contents to input
		}
	}

	public void LeagueofLegendsHomeSeasonRecord(string s)
	{
		string LeagueofLegendsHomeSeasonRecordInput = s;

		Debug.Log("Home Team Season Record.txt: " + LeagueofLegendsHomeSeasonRecordInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Season Record.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomeSeasonRecordInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomeSeasonRecordInput);
	}

	public void LeagueofLegendsHomeSeriesScoreIncrement()
	{
		string maxValue = "3";
		string path = "Assets/Games/LeagueofLegends/Home Team Series Score.txt";
		if (LeagueofLegendsHomeSeriesScoreInputField != null && LeagueofLegendsHomeSeriesScoreInputField.text != maxValue)
		{
			++LeagueofLegendsHomeSeriesScoreValue;
			LeagueofLegendsHomeSeriesScoreInput = LeagueofLegendsHomeSeriesScoreValue.ToString();
			LeagueofLegendsHomeSeriesScoreInputField.text = LeagueofLegendsHomeSeriesScoreValue.ToString();
			Debug.Log("Increment - Home Team Series Score.txt: " + LeagueofLegendsHomeSeriesScoreInputField.text);
			File.WriteAllText(path, LeagueofLegendsHomeSeriesScoreInputField.text);
		}
	}

	public void LeagueofLegendsHomeSeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/LeagueofLegends/Home Team Series Score.txt";
		if (LeagueofLegendsHomeSeriesScoreInputField != null && LeagueofLegendsHomeSeriesScoreInputField.text != minValue)
		{
			--LeagueofLegendsHomeSeriesScoreValue;
			LeagueofLegendsHomeSeriesScoreInput = LeagueofLegendsHomeSeriesScoreValue.ToString();
			LeagueofLegendsHomeSeriesScoreInputField.text = LeagueofLegendsHomeSeriesScoreValue.ToString();
			Debug.Log("Decrement - Home Team Series Score.txt: " + LeagueofLegendsHomeSeriesScoreInputField.text);
			File.WriteAllText(path, LeagueofLegendsHomeSeriesScoreInputField.text);
		}
	}

	public void LeagueofLegendsHomeSeriesScore(string s)
	{
		string path = "Assets/Games/LeagueofLegends/Home Team Series Score.txt";
		LeagueofLegendsHomeSeriesScoreInput = s;
		LeagueofLegendsHomeSeriesScoreInput = LeagueofLegendsHomeSeriesScoreValue.ToString();
		LeagueofLegendsHomeSeriesScoreValue = Convert.ToInt32(LeagueofLegendsHomeSeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Score.txt: " + LeagueofLegendsHomeSeriesScoreValue);
		File.WriteAllText(path, LeagueofLegendsHomeSeriesScoreInputField.text);
	}

	public void LeagueofLegendsHomePlayer1(string s)
	{
		string LeagueofLegendsHomePlayer1Input = s;

		Debug.Log("Home Team Player1.txt: " + LeagueofLegendsHomePlayer1Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Player1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer1Input);
	}

	public void LeagueofLegendsHomePlayer2(string s)
	{
		string LeagueofLegendsHomePlayer2Input = s;

		Debug.Log("Home Team Player2.txt: " + LeagueofLegendsHomePlayer2Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer2Input);
	}

	public void LeagueofLegendsHomePlayer3(string s)
	{
		string LeagueofLegendsHomePlayer3Input = s;

		Debug.Log("Home Team Player3.txt: " + LeagueofLegendsHomePlayer3Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer3Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer3Input);
	}

	public void LeagueofLegendsHomePlayer4(string s)
	{
		string LeagueofLegendsHomePlayer4Input = s;

		Debug.Log("Home Team Player4.txt: " + LeagueofLegendsHomePlayer4Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Player4.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer4Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer4Input);
	}

	public void LeagueofLegendsHomePlayer5(string s)
	{
		string LeagueofLegendsHomePlayer5Input = s;

		Debug.Log("Home Team Player5.txt: " + LeagueofLegendsHomePlayer5Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Player5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer5Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer5Input);
	}

	public void LeagueofLegendsHomePlayer1Stats(string s)
	{
		string LeagueofLegendsHomePlayer1StatsInput = s;

		Debug.Log("Home Team Player1 Stats.txt: " + LeagueofLegendsHomePlayer1StatsInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Player1 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer1StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer1StatsInput);
	}

	public void LeagueofLegendsHomePlayer2Stats(string s)
	{
		string LeagueofLegendsHomePlayer2StatsInput = s;

		Debug.Log("Home Team Player2 Stats.txt: " + LeagueofLegendsHomePlayer2StatsInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Player2 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer2StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer2StatsInput);
	}

	public void LeagueofLegendsHomePlayer3Stats(string s)
	{
		string LeagueofLegendsHomePlayer3StatsInput = s;

		Debug.Log("Home Team Player3 Stats.txt: " + LeagueofLegendsHomePlayer3StatsInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Player3 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer3StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer3StatsInput);
	}

	public void LeagueofLegendsHomePlayer4Stats(string s)
	{
		string LeagueofLegendsHomePlayer4StatsInput = s;

		Debug.Log("Home Team Player4 Stats.txt: " + LeagueofLegendsHomePlayer4StatsInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Player4 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer4StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer4StatsInput);
	}

	public void LeagueofLegendsHomePlayer5Stats(string s)
	{
		string LeagueofLegendsHomePlayer5StatsInput = s;

		Debug.Log("Home Team Player5 Stats.txt: " + LeagueofLegendsHomePlayer5StatsInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Home Team Player5 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer5StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer5StatsInput);
	}

	public void LeagueofLegendsAwayDDValue(Dropdown sender)
	{
		LeagueofLegendsAwayDDStringInput = LeagueofLegendsAwayDDInput.options[LeagueofLegendsAwayDDInput.value].text;
		Debug.Log("Away Team Name.txt: " + LeagueofLegendsAwayDDStringInput);

		string path = "Assets/Games/LeagueofLegends/Away Team Name.txt"; // This is the directory for the text file.

		if (LeagueofLegendsAwayDDStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoBlank);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (LeagueofLegendsAwayDDStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoSR);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);
		}
		if (LeagueofLegendsAwayDDStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoRIT);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (LeagueofLegendsAwayDDStringInput == "UALBANY")

		{
			string logoUA = "UA Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoUA);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (LeagueofLegendsAwayDDStringInput == "NYIT")

		{
			string logoNYIT = "NYIT Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoNYIT);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}


		if (LeagueofLegendsAwayDDStringInput == "SPU")

		{
			string logoSPU = "SPU Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoSPU);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}


		if (LeagueofLegendsAwayDDStringInput == "POLYTECHNIC")

		{
			string logoSP = "SP Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/LeagueofLegends/";

			string sourceFile = Path.Combine(sourcePath, logoSP);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (LeagueofLegendsAwayDDStringInput != "SELECT TEAM")
		{
			File.WriteAllText(path, LeagueofLegendsAwayDDStringInput); // sets the location to path and the contents to input
		}
	}

	public void LeagueofLegendsAwaySeasonRecord(string s)
	{
		string LeagueofLegendsAwaySeasonRecordInput = s;

		Debug.Log("Away Team Season Record.txt: " + LeagueofLegendsAwaySeasonRecordInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Season Record.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsAwaySeasonRecordInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsAwaySeasonRecordInput);
	}

	public void LeagueofLegendsAwaySeriesScoreIncrement()
	{
		string maxValue = "3";
		string path = "Assets/Games/LeagueofLegends/Away Team Series Score.txt";
		if (LeagueofLegendsAwaySeriesScoreInputField != null && LeagueofLegendsAwaySeriesScoreInputField.text != maxValue)
		{
			++LeagueofLegendsAwaySeriesScoreValue;
			LeagueofLegendsAwaySeriesScoreInput = LeagueofLegendsAwaySeriesScoreValue.ToString();
			LeagueofLegendsAwaySeriesScoreInputField.text = LeagueofLegendsAwaySeriesScoreValue.ToString();
			Debug.Log("Increment - Away Team Series Score.txt: " + LeagueofLegendsAwaySeriesScoreInputField.text);
			File.WriteAllText(path, LeagueofLegendsAwaySeriesScoreInputField.text);
		}
	}

	public void LeagueofLegendsAwaySeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/LeagueofLegends/Away Team Series Score.txt";
		if (LeagueofLegendsAwaySeriesScoreInputField != null && LeagueofLegendsAwaySeriesScoreInputField.text != minValue)
		{
			--LeagueofLegendsAwaySeriesScoreValue;
			LeagueofLegendsAwaySeriesScoreInput = LeagueofLegendsAwaySeriesScoreValue.ToString();
			LeagueofLegendsAwaySeriesScoreInputField.text = LeagueofLegendsAwaySeriesScoreValue.ToString();
			Debug.Log("Decrement - Away Team Series Score.txt: " + LeagueofLegendsAwaySeriesScoreInputField.text);
			File.WriteAllText(path, LeagueofLegendsAwaySeriesScoreInputField.text);
		}
	}

	public void LeagueofLegendsAwaySeriesScore(string s)
	{
		string path = "Assets/Games/LeagueofLegends/Away Team Series Score.txt";
		LeagueofLegendsAwaySeriesScoreInput = s;
		LeagueofLegendsAwaySeriesScoreInput = LeagueofLegendsAwaySeriesScoreValue.ToString();
		LeagueofLegendsAwaySeriesScoreValue = Convert.ToInt32(LeagueofLegendsAwaySeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Score.txt: " + LeagueofLegendsAwaySeriesScoreValue);
		File.WriteAllText(path, LeagueofLegendsAwaySeriesScoreInputField.text);
	}

	public void LeagueofLegendsAwayPlayer1(string s)
	{
		string LeagueofLegendsAwayPlayer1Input = s;

		Debug.Log("Away Team Player1.txt: " + LeagueofLegendsAwayPlayer1Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Player1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsAwayPlayer1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsAwayPlayer1Input);
	}

	public void LeagueofLegendsAwayPlayer2(string s)
	{
		string LeagueofLegendsAwayPlayer2Input = s;

		Debug.Log("Away Team Player2.txt: " + LeagueofLegendsAwayPlayer2Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsAwayPlayer2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsAwayPlayer2Input);
	}

	public void LeagueofLegendsAwayPlayer3(string s)
	{
		string LeagueofLegendsAwayPlayer3Input = s;

		Debug.Log("Away Team Player3.txt: " + LeagueofLegendsAwayPlayer3Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsAwayPlayer3Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsAwayPlayer3Input);
	}

	public void LeagueofLegendsAwayPlayer4(string s)
	{
		string LeagueofLegendsAwayPlayer4Input = s;

		Debug.Log("Away Team Player4.txt: " + LeagueofLegendsAwayPlayer4Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Player4.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsAwayPlayer4Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsAwayPlayer4Input);
	}

	public void LeagueofLegendsAwayPlayer5(string s)
	{
		string LeagueofLegendsHomePlayer5Input = s;

		Debug.Log("Away Team Player5.txt: " + LeagueofLegendsHomePlayer5Input); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Player5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer5Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer5Input);
	}

	public void LeagueofLegendsAwayPlayer1Stats(string s)
	{
		string LeagueofLegendsAwayPlayer1StatsInput = s;

		Debug.Log("Away Team Player1 Stats.txt: " + LeagueofLegendsAwayPlayer1StatsInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Player1 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsAwayPlayer1StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsAwayPlayer1StatsInput);
	}

	public void LeagueofLegendsAwayPlayer2Stats(string s)
	{
		string LeagueofLegendsAwayPlayer2StatsInput = s;

		Debug.Log("Away Team Player2 Stats.txt: " + LeagueofLegendsAwayPlayer2StatsInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Player2 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsAwayPlayer2StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsAwayPlayer2StatsInput);
	}

	public void LeagueofLegendsAwayPlayer3Stats(string s)
	{
		string LeagueofLegendsAwayPlayer3StatsInput = s;

		Debug.Log("Away Team Player3 Stats.txt: " + LeagueofLegendsAwayPlayer3StatsInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Player3 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsAwayPlayer3StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsAwayPlayer3StatsInput);
	}

	public void LeagueofLegendsAwayPlayer4Stats(string s)
	{
		string LeagueofLegendsAwayPlayer4StatsInput = s;

		Debug.Log("Away Team Player4 Stats.txt: " + LeagueofLegendsAwayPlayer4StatsInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Player4 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsAwayPlayer4StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsAwayPlayer4StatsInput);
	}

	public void LeagueofLegendsAwayPlayer5Stats(string s)
	{
		string LeagueofLegendsHomePlayer5StatsInput = s;

		Debug.Log("Away Team Player5 Stats.txt: " + LeagueofLegendsHomePlayer5StatsInput); // shows input in debug

		string path = "Assets/Games/LeagueofLegends/Away Team Player5 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, LeagueofLegendsHomePlayer5StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, LeagueofLegendsHomePlayer5StatsInput);
	}

}
