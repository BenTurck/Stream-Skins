using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Amazon.DynamoDBv2;

public class OverwatchWritetoFile : MonoBehaviour
{
	public Dropdown OverwatchHomeDDInput;

	private string OverwatchHomeDDStringInput;

	public string OverwatchHomeSeriesScoreInput;

	public InputField OverwatchHomeSeriesScoreInputField;

	public int OverwatchHomeSeriesScoreValue = 0;

	public Dropdown OverwatchGame1DDInput;

	private string OverwatchGame1DDStringInput;

	public Dropdown OverwatchGame2DDInput;

	private string OverwatchGame2DDStringInput;

	public Dropdown OverwatchGame3DDInput;

	private string OverwatchGame3DDStringInput;

	public Dropdown OverwatchGame4DDInput;

	private string OverwatchGame4DDStringInput;

	public Dropdown OverwatchGame5DDInput;

	private string OverwatchGame5DDStringInput;

	public Dropdown OverwatchAwayDDInput;

	private string OverwatchAwayDDStringInput;

	public string OverwatchAwaySeriesScoreInput;

	public InputField OverwatchAwaySeriesScoreInputField;

	public int OverwatchAwaySeriesScoreValue = 0;




	//Start is called before the first frame update
	void Start()
	{
		OverwatchHomeDDInput.onValueChanged.AddListener(delegate
		{
			OverwatchHomeDDValue(OverwatchHomeDDInput);

		});

		OverwatchAwayDDInput.onValueChanged.AddListener(delegate
		{
			OverwatchAwayDDValue(OverwatchAwayDDInput);

		});

		OverwatchGame1DDInput.onValueChanged.AddListener(delegate
		{
			OverwatchGame1DDValue(OverwatchGame1DDInput);

		});

		OverwatchGame2DDInput.onValueChanged.AddListener(delegate
		{
			OverwatchGame2DDValue(OverwatchGame2DDInput);

		});

		OverwatchGame3DDInput.onValueChanged.AddListener(delegate
		{
			OverwatchGame3DDValue(OverwatchGame3DDInput);

		});

		OverwatchGame4DDInput.onValueChanged.AddListener(delegate
		{
			OverwatchGame4DDValue(OverwatchGame4DDInput);

		});

		OverwatchGame5DDInput.onValueChanged.AddListener(delegate
		{
			OverwatchGame5DDValue(OverwatchGame5DDInput);

		});

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OverwatchTicker(string s)
	{
		string OverwatchTickerInput = s;

		Debug.Log("Ticker.txt: " + OverwatchTickerInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Ticker.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchTickerInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchTickerInput);
	}

	public void OverwatchCaster1(string s)
	{
		string OverwatchCaster1Input = s;

		Debug.Log("Caster1.txt: " + OverwatchCaster1Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Caster1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchCaster1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchCaster1Input);
	}

	public void OverwatchCaster2(string s)
	{
		string OverwatchCaster2Input = s;

		Debug.Log("Caster2.txt: " + OverwatchCaster2Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Caster2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchCaster2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchCaster2Input);
	}

	public void OverwatchGame1DDValue(Dropdown sender)
	{
		OverwatchGame1DDStringInput = OverwatchGame1DDInput.options[OverwatchGame1DDInput.value].text;

		string path1 = "Assets/Games/Overwatch/Map1 Name.txt";


		string map1Blank = "Blank.png";
		string map1Busan = "Overwatch Busan.png";
		string map1Ilios = "Overwatch Ilios.png";
		string map1LijiangTower = "Overwatch Lijiang. Tower.png";
		string map1Nepal = "Overwatch Nepal.png";
		string map1Oasis = "Overwatch Oasis.png";


		string map1 = "Map 1.png";
		string sourceMap1Path = "Assets/GameMaps/";
		string targetMap1Path = "Assets/Games/Overwatch/";

		string sourceMap1BlankFile = Path.Combine(sourceMap1Path, map1Blank);
		string sourceMap1BusanFile = Path.Combine(sourceMap1Path, map1Busan);
		string sourceMap1IliosFile = Path.Combine(sourceMap1Path, map1Ilios);
		string sourceMap1LijiangTowerFile = Path.Combine(sourceMap1Path, map1LijiangTower);
		string sourceMap1NepalFile = Path.Combine(sourceMap1Path, map1Nepal);
		string sourceMap1OasisFile = Path.Combine(sourceMap1Path, map1Oasis);

		string destMap1File = Path.Combine(targetMap1Path, map1);

		if (OverwatchGame1DDStringInput == "SELECT MAP 1")
		{
			File.Copy(sourceMap1BlankFile, destMap1File, true);
			File.WriteAllText(path1, "");
			Debug.Log("Map1 Name.txt: ");
		}

		if (OverwatchGame1DDStringInput == "BUSAN")
		{
			File.Copy(sourceMap1BusanFile, destMap1File, true);
			File.WriteAllText(path1, OverwatchGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + OverwatchGame1DDStringInput);
		}

		if (OverwatchGame1DDStringInput == "ILIOS")
		{
			File.Copy(sourceMap1IliosFile, destMap1File, true);
			File.WriteAllText(path1, OverwatchGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + OverwatchGame1DDStringInput);
		}

		if (OverwatchGame1DDStringInput == "LIJIANG TOWER")
		{
			File.Copy(sourceMap1LijiangTowerFile, destMap1File, true);
			File.WriteAllText(path1, OverwatchGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + OverwatchGame1DDStringInput);
		}

		if (OverwatchGame1DDStringInput == "NEPAL")
		{
			File.Copy(sourceMap1NepalFile, destMap1File, true);
			File.WriteAllText(path1, OverwatchGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + OverwatchGame1DDStringInput);
		}

		if (OverwatchGame1DDStringInput == "OASIS")
		{
			File.Copy(sourceMap1OasisFile, destMap1File, true);
			File.WriteAllText(path1, OverwatchGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + OverwatchGame1DDStringInput);
		}
	}

	public void OverwatchGame2DDValue(Dropdown sender)
	{
		OverwatchGame2DDStringInput = OverwatchGame2DDInput.options[OverwatchGame2DDInput.value].text;

		string path2 = "Assets/Games/Overwatch/Map2 Name.txt";


		string map2Blank = "Blank.png";
		string map2Hanamura = "Overwatch Hanamura.png";
		string map2TempleofAnubis = "Overwatch Temple of Anubis.png";
		string map2VolskayaIndustries = "Overwatch Volskaya Industries.png";



		string map2 = "Map 2.png";
		string sourceMap2Path = "Assets/GameMaps/";
		string targetMap2Path = "Assets/Games/Overwatch/";

		string sourceMap2BlankFile = Path.Combine(sourceMap2Path, map2Blank);
		string sourceMap2AscentFile = Path.Combine(sourceMap2Path, map2Hanamura);
		string sourceMap2TempleOfAnubisFile = Path.Combine(sourceMap2Path, map2TempleofAnubis);
		string sourceMap2VolskayaIndustriesFile = Path.Combine(sourceMap2Path, map2VolskayaIndustries);


		string destMap2File = Path.Combine(targetMap2Path, map2);

		if (OverwatchGame2DDStringInput == "SELECT MAP 2")
		{
			File.Copy(sourceMap2BlankFile, destMap2File, true);
			File.WriteAllText(path2, "");
			Debug.Log("Map2 Name.txt: ");
		}

		if (OverwatchGame2DDStringInput == "HANAMURA")
		{
			File.Copy(sourceMap2AscentFile, destMap2File, true);
			File.WriteAllText(path2, OverwatchGame2DDStringInput);
			Debug.Log("Map2 Name.txt: " + OverwatchGame2DDStringInput);
		}

		if (OverwatchGame2DDStringInput == "TEMPLE OF ANUBIS")
		{
			File.Copy(sourceMap2TempleOfAnubisFile, destMap2File, true);
			File.WriteAllText(path2, OverwatchGame2DDStringInput);
			Debug.Log("Map2 Name.txt: " + OverwatchGame2DDStringInput);
		}

		if (OverwatchGame2DDStringInput == "VOLSKAYA INDUSTRIES")
		{
			File.Copy(sourceMap2VolskayaIndustriesFile, destMap2File, true);
			File.WriteAllText(path2, OverwatchGame2DDStringInput);
			Debug.Log("Map2 Name.txt: " + OverwatchGame2DDStringInput);
		}
	}

	public void OverwatchGame3DDValue(Dropdown sender)
	{
		OverwatchGame3DDStringInput = OverwatchGame3DDInput.options[OverwatchGame3DDInput.value].text;

		string path3 = "Assets/Games/Overwatch/Map3 Name.txt";


		string map3Blank = "Blank.png";
		string map3BlizzardWorld = "Overwatch Blizzard World.png";
		string map3Eichenwalde = "Overwatch Eichenwalde.png";
		string map3KingsRow = "Overwatch Breeze.png";


		string map3 = "Map 3.png";
		string sourceMap3Path = "Assets/GameMaps/";
		string targetMap3Path = "Assets/Games/Overwatch/";

		string sourceMap3BlankFile = Path.Combine(sourceMap3Path, map3Blank);
		string sourceMap3BlizzardWorldFile = Path.Combine(sourceMap3Path, map3BlizzardWorld);
		string sourceMap3EichenwaldeFile = Path.Combine(sourceMap3Path, map3Eichenwalde);
		string sourceMap3KingsRowFile = Path.Combine(sourceMap3Path, map3KingsRow);

		string destMap3File = Path.Combine(targetMap3Path, map3);

		if (OverwatchGame3DDStringInput == "SELECT MAP 3")
		{
			File.Copy(sourceMap3BlankFile, destMap3File, true);
			File.WriteAllText(path3, "");
			Debug.Log("Map3 Name.txt: ");
		}

		if (OverwatchGame3DDStringInput == "BLIZZARD WORLD")
		{
			File.Copy(sourceMap3BlizzardWorldFile, destMap3File, true);
			File.WriteAllText(path3, OverwatchGame3DDStringInput);
			Debug.Log("Map3 Name.txt: " + OverwatchGame3DDStringInput);
		}

		if (OverwatchGame3DDStringInput == "EICHENWALDE")
		{
			File.Copy(sourceMap3EichenwaldeFile, destMap3File, true);
			File.WriteAllText(path3, OverwatchGame3DDStringInput);
			Debug.Log("Map3 Name.txt: " + OverwatchGame3DDStringInput);
		}

		if (OverwatchGame3DDStringInput == "KING'S ROW")
		{
			File.Copy(sourceMap3KingsRowFile, destMap3File, true);
			File.WriteAllText(path3, OverwatchGame3DDStringInput);
			Debug.Log("Map3 Name.txt: " + OverwatchGame3DDStringInput);
		}
	}

	public void OverwatchGame4DDValue(Dropdown sender)
	{
		OverwatchGame4DDStringInput = OverwatchGame4DDInput.options[OverwatchGame4DDInput.value].text;

		string path4 = "Assets/Games/Overwatch/Map4 Name.txt";


		string map4Blank = "Blank.png";
		string map4Dorado = "Overwatch Dorado.png";
		string map4Havana = "Overwatch Hava.png";
		string map4Gibraltar = "Overwatch Breeze.png";

		string map4 = "Map 4.png";
		string sourceMap4Path = "Assets/GameMaps/";
		string targetMap4Path = "Assets/Games/Overwatch/";

		string sourceMap4BlankFile = Path.Combine(sourceMap4Path, map4Blank);
		string sourceMap4DoradoFile = Path.Combine(sourceMap4Path, map4Dorado);
		string sourceMap4HavanaFile = Path.Combine(sourceMap4Path, map4Havana);
		string sourceMap4GibraltarFile = Path.Combine(sourceMap4Path, map4Gibraltar);

		string destMap4File = Path.Combine(targetMap4Path, map4);

		if (OverwatchGame4DDStringInput == "SELECT MAP 4")
		{
			File.Copy(sourceMap4BlankFile, destMap4File, true);
			File.WriteAllText(path4, "");
			Debug.Log("Map4 Name.txt: ");
		}

		if (OverwatchGame4DDStringInput == "DORADO")
		{
			File.Copy(sourceMap4DoradoFile, destMap4File, true);
			File.WriteAllText(path4, OverwatchGame4DDStringInput);
			Debug.Log("Map4 Name.txt: " + OverwatchGame4DDStringInput);
		}

		if (OverwatchGame4DDStringInput == "HAVANA")
		{
			File.Copy(sourceMap4HavanaFile, destMap4File, true);
			File.WriteAllText(path4, OverwatchGame4DDStringInput);
			Debug.Log("Map4 Name.txt: " + OverwatchGame4DDStringInput);
		}

		if (OverwatchGame4DDStringInput == "GIBRALTAR")
		{
			File.Copy(sourceMap4GibraltarFile, destMap4File, true);
			File.WriteAllText(path4, OverwatchGame4DDStringInput);
			Debug.Log("Map4 Name.txt: " + OverwatchGame4DDStringInput);
		}
	}

	public void OverwatchGame5DDValue(Dropdown sender)
	{
		OverwatchGame5DDStringInput = OverwatchGame5DDInput.options[OverwatchGame5DDInput.value].text;

		string path5 = "Assets/Games/Overwatch/Map5 Name.txt";


		string map5Blank = "Blank.png";
		string map5Busan = "Overwatch Busan.png";
		string map5Ilios = "Overwatch Ilios.png";
		string map5LijiangTower = "Overwatch Lijiang. Tower.png";
		string map5Nepal = "Overwatch Nepal.png";
		string map5Oasis = "Overwatch Oasis.png";


		string map5 = "Map 5.png";
		string sourceMap5Path = "Assets/GameMaps/";
		string targetMap5Path = "Assets/Games/Overwatch/";

		string sourceMap5BlankFile = Path.Combine(sourceMap5Path, map5Blank);
		string sourceMap5BusanFile = Path.Combine(sourceMap5Path, map5Busan);
		string sourceMap5IliosFile = Path.Combine(sourceMap5Path, map5Ilios);
		string sourceMap5LijiangTowerFile = Path.Combine(sourceMap5Path, map5LijiangTower);
		string sourceMap5NepalFile = Path.Combine(sourceMap5Path, map5Nepal);
		string sourceMap5OasisFile = Path.Combine(sourceMap5Path, map5Oasis);

		string destMap1File = Path.Combine(targetMap5Path, map5);

		if (OverwatchGame5DDStringInput == "SELECT MAP 5")
		{
			File.Copy(sourceMap5BlankFile, destMap1File, true);
			File.WriteAllText(path5, "");
			Debug.Log("Map5 Name.txt: ");
		}

		if (OverwatchGame5DDStringInput == "BUSAN")
		{
			File.Copy(sourceMap5BusanFile, destMap1File, true);
			File.WriteAllText(path5, OverwatchGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + OverwatchGame5DDStringInput);
		}

		if (OverwatchGame5DDStringInput == "ILIOS")
		{
			File.Copy(sourceMap5IliosFile, destMap1File, true);
			File.WriteAllText(path5, OverwatchGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + OverwatchGame5DDStringInput);
		}

		if (OverwatchGame5DDStringInput == "LIJIANG TOWER")
		{
			File.Copy(sourceMap5LijiangTowerFile, destMap1File, true);
			File.WriteAllText(path5, OverwatchGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + OverwatchGame5DDStringInput);
		}

		if (OverwatchGame5DDStringInput == "NEPAL")
		{
			File.Copy(sourceMap5NepalFile, destMap1File, true);
			File.WriteAllText(path5, OverwatchGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + OverwatchGame5DDStringInput);
		}

		if (OverwatchGame5DDStringInput == "OASIS")
		{
			File.Copy(sourceMap5OasisFile, destMap1File, true);
			File.WriteAllText(path5, OverwatchGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + OverwatchGame5DDStringInput);
		}
	}

	public void OverwatchHomeGame1Toggle(bool tog)
	{
		OverwatchHomeDDStringInput = OverwatchHomeDDInput.options[OverwatchHomeDDInput.value].text;
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + OverwatchHomeDDStringInput + text2;
		string path = "Assets/Games/Overwatch/Game1 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 1 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Overwatch/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 1 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Overwatch/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (OverwatchAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + OverwatchHomeDDStringInput + text2);
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

	public void OverwatchHomeGame2Toggle(bool tog)
	{
		OverwatchHomeDDStringInput = OverwatchHomeDDInput.options[OverwatchHomeDDInput.value].text;
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + OverwatchHomeDDStringInput + text2;
		string path = "Assets/Games/Overwatch/Game2 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 2 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Overwatch/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 2 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Overwatch/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (OverwatchAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + OverwatchHomeDDStringInput + text2);
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

	public void OverwatchHomeGame3Toggle(bool tog)
	{
		OverwatchHomeDDStringInput = OverwatchHomeDDInput.options[OverwatchHomeDDInput.value].text;
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + OverwatchHomeDDStringInput + text2;
		string path = "Assets/Games/Overwatch/Game3 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 3 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Overwatch/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 3 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Overwatch/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (OverwatchAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + OverwatchHomeDDStringInput + text2);
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

	public void OverwatchHomeGame4Toggle(bool tog)
	{
		OverwatchHomeDDStringInput = OverwatchHomeDDInput.options[OverwatchHomeDDInput.value].text;
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + OverwatchHomeDDStringInput + text2;
		string path = "Assets/Games/Overwatch/Game4 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 4 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Overwatch/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 4 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Overwatch/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (OverwatchAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + OverwatchHomeDDStringInput + text2);
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

	public void OverwatchHomeGame5Toggle(bool tog)
	{
		OverwatchHomeDDStringInput = OverwatchHomeDDInput.options[OverwatchHomeDDInput.value].text;
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + OverwatchHomeDDStringInput + text2;
		string path = "Assets/Games/Overwatch/Game5 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 5 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Overwatch/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 5 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Overwatch/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (OverwatchAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + OverwatchHomeDDStringInput + text2);
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

	public void OverwatchGame1Score(string s)
	{
		string OverwatchGame1ScoreInput = s;

		Debug.Log("Game1 Score.txt: " + OverwatchGame1ScoreInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Game1 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchGame1ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchGame1ScoreInput);

	}

	public void OverwatchGame2Score(string s)
	{
		string OverwatchGame2ScoreInput = s;

		Debug.Log("Game2 Score.txt: " + OverwatchGame2ScoreInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Game2 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchGame2ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchGame2ScoreInput);
	}

	public void OverwatchGame3Score(string s)
	{
		string OverwatchGame3ScoreInput = s;

		Debug.Log("Game3 Score.txt: " + OverwatchGame3ScoreInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Game3 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchGame3ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchGame3ScoreInput);
	}

	public void OverwatchGame4Score(string s)
	{
		string OverwatchGame4ScoreInput = s;

		Debug.Log("Game4 Score.txt: " + OverwatchGame4ScoreInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Game4 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchGame4ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchGame4ScoreInput);
	}

	public void OverwatchGame5Score(string s)
	{
		string OverwatchGame5ScoreInput = s;

		Debug.Log("Game5 Score.txt: " + OverwatchGame5ScoreInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Game5 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchGame5ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchGame5ScoreInput);
	}

	public void OverwatchAwayGame1Toggle(bool tog)
	{
		OverwatchAwayDDStringInput = OverwatchAwayDDInput.options[OverwatchAwayDDInput.value].text;
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + OverwatchAwayDDStringInput + text2;
		string path = "Assets/Games/Overwatch/Game1 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 1 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Overwatch/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 1 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Overwatch/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (OverwatchAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + OverwatchAwayDDStringInput + text2);
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

	public void OverwatchAwayGame2Toggle(bool tog)
	{
		OverwatchAwayDDStringInput = OverwatchAwayDDInput.options[OverwatchAwayDDInput.value].text;
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + OverwatchAwayDDStringInput + text2;
		string path = "Assets/Games/Overwatch/Game2 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 2 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Overwatch/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 2 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Overwatch/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (OverwatchAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + OverwatchAwayDDStringInput + text2);
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

	public void OverwatchAwayGame3Toggle(bool tog)
	{
		OverwatchAwayDDStringInput = OverwatchAwayDDInput.options[OverwatchAwayDDInput.value].text;
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + OverwatchAwayDDStringInput + text2;
		string path = "Assets/Games/Overwatch/Game3 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 3 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Overwatch/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 3 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Overwatch/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (OverwatchAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + OverwatchAwayDDStringInput + text2);
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

	public void OverwatchAwayGame4Toggle(bool tog)
	{
		OverwatchAwayDDStringInput = OverwatchAwayDDInput.options[OverwatchAwayDDInput.value].text;
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + OverwatchAwayDDStringInput + text2;
		string path = "Assets/Games/Overwatch/Game4 Winner.txt";


		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 4 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Overwatch/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 4 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Overwatch/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (OverwatchAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + OverwatchAwayDDStringInput + text2);
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

	public void OverwatchAwayGame5Toggle(bool tog)
	{
		OverwatchAwayDDStringInput = OverwatchAwayDDInput.options[OverwatchAwayDDInput.value].text;
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + OverwatchAwayDDStringInput + text2;
		string path = "Assets/Games/Overwatch/Game5 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 5 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Overwatch/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 5 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Overwatch/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (OverwatchAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + OverwatchAwayDDStringInput + text2);
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

	public void OverwatchHomeDDValue(Dropdown sender)
	{
		OverwatchHomeDDStringInput = OverwatchHomeDDInput.options[OverwatchHomeDDInput.value].text;
		Debug.Log("Home Team Name.txt: " + OverwatchHomeDDStringInput);

		string path = "Assets/Games/Overwatch/Home Team Name.txt"; // This is the directory for the text file.

		if (OverwatchHomeDDStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoBlank);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (OverwatchHomeDDStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoSR);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);
		}
		if (OverwatchHomeDDStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoRIT);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (OverwatchHomeDDStringInput == "UALBANY")

		{
			string logoUA = "UA Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoUA);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (OverwatchHomeDDStringInput == "NYIT")

		{
			string logoNYIT = "NYIT Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoNYIT);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (OverwatchHomeDDStringInput == "SPU")

		{
			string logoSPU = "SPU Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoSPU);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (OverwatchHomeDDStringInput == "POLYTECHNIC")

		{
			string logoSP = "SP Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoSP);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (OverwatchHomeDDStringInput != "SELECT TEAM")
		{
			File.WriteAllText(path, OverwatchHomeDDStringInput); // sets the location to path and the contents to input
		}
	}

	public void OverwatchHomeSeasonRecord(string s)
	{
		string OverwatchHomeSeasonRecordInput = s;

		Debug.Log("Home Team Season Record.txt: " + OverwatchHomeSeasonRecordInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Season Record.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomeSeasonRecordInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomeSeasonRecordInput);
	}

	public void OverwatchHomeSeriesScoreIncrement()
	{
		string maxValue = "3";
		string path = "Assets/Games/Overwatch/Home Team Series Score.txt";
		if (OverwatchHomeSeriesScoreInputField != null && OverwatchHomeSeriesScoreInputField.text != maxValue)
		{
			++OverwatchHomeSeriesScoreValue;
			OverwatchHomeSeriesScoreInput = OverwatchHomeSeriesScoreValue.ToString();
			OverwatchHomeSeriesScoreInputField.text = OverwatchHomeSeriesScoreValue.ToString();
			Debug.Log("Increment - Home Team Series Score.txt: " + OverwatchHomeSeriesScoreInputField.text);
			File.WriteAllText(path, OverwatchHomeSeriesScoreInputField.text);
		}
	}

	public void OverwatchHomeSeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/Overwatch/Home Team Series Score.txt";
		if (OverwatchHomeSeriesScoreInputField != null && OverwatchHomeSeriesScoreInputField.text != minValue)
		{
			--OverwatchHomeSeriesScoreValue;
			OverwatchHomeSeriesScoreInput = OverwatchHomeSeriesScoreValue.ToString();
			OverwatchHomeSeriesScoreInputField.text = OverwatchHomeSeriesScoreValue.ToString();
			Debug.Log("Decrement - Home Team Series Score.txt: " + OverwatchHomeSeriesScoreInputField.text);
			File.WriteAllText(path, OverwatchHomeSeriesScoreInputField.text);
		}
	}

	public void OverwatchHomeSeriesScore(string s)
	{
		string path = "Assets/Games/Overwatch/Home Team Series Score.txt";
		OverwatchHomeSeriesScoreInput = s;
		OverwatchHomeSeriesScoreInput = OverwatchHomeSeriesScoreValue.ToString();
		OverwatchHomeSeriesScoreValue = Convert.ToInt32(OverwatchHomeSeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Score.txt: " + OverwatchHomeSeriesScoreValue);
		File.WriteAllText(path, OverwatchHomeSeriesScoreInputField.text);
	}

	public void OverwatchHomePlayer1(string s)
	{
		string OverwatchHomePlayer1Input = s;

		Debug.Log("Home Team Player1.txt: " + OverwatchHomePlayer1Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer1Input);
	}

	public void OverwatchHomePlayer2(string s)
	{
		string OverwatchHomePlayer2Input = s;

		Debug.Log("Home Team Player2.txt: " + OverwatchHomePlayer2Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer2Input);
	}

	public void OverwatchHomePlayer3(string s)
	{
		string OverwatchHomePlayer3Input = s;

		Debug.Log("Home Team Player3.txt: " + OverwatchHomePlayer3Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer3Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer3Input);
	}

	public void OverwatchHomePlayer4(string s)
	{
		string OverwatchHomePlayer4Input = s;

		Debug.Log("Home Team Player4.txt: " + OverwatchHomePlayer4Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player4.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer4Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer4Input);
	}

	public void OverwatchHomePlayer5(string s)
	{
		string OverwatchHomePlayer5Input = s;

		Debug.Log("Home Team Player5.txt: " + OverwatchHomePlayer5Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer5Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer5Input);
	}

	public void OverwatchHomePlayer6(string s)
	{
		string OverwatchHomePlayer6Input = s;

		Debug.Log("Home Team Player6.txt: " + OverwatchHomePlayer6Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player6.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer6Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer6Input);
	}

	public void OverwatchHomePlayer1Stats(string s)
	{
		string OverwatchHomePlayer1StatsInput = s;

		Debug.Log("Home Team Player1 Stats.txt: " + OverwatchHomePlayer1StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player1 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer1StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer1StatsInput);
	}

	public void OverwatchHomePlayer2Stats(string s)
	{
		string OverwatchHomePlayer2StatsInput = s;

		Debug.Log("Home Team Player2 Stats.txt: " + OverwatchHomePlayer2StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player2 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer2StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer2StatsInput);
	}

	public void OverwatchHomePlayer3Stats(string s)
	{
		string OverwatchHomePlayer3StatsInput = s;

		Debug.Log("Home Team Player3 Stats.txt: " + OverwatchHomePlayer3StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player3 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer3StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer3StatsInput);
	}

	public void OverwatchHomePlayer4Stats(string s)
	{
		string OverwatchHomePlayer4StatsInput = s;

		Debug.Log("Home Team Player4 Stats.txt: " + OverwatchHomePlayer4StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player4 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer4StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer4StatsInput);
	}

	public void OverwatchHomePlayer5Stats(string s)
	{
		string OverwatchHomePlayer5StatsInput = s;

		Debug.Log("Home Team Player5 Stats.txt: " + OverwatchHomePlayer5StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player5 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer5StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer5StatsInput);
	}

	public void OverwatchHomePlayer6Stats(string s)
	{
		string OverwatchHomePlayer6StatsInput = s;

		Debug.Log("Home Team Player6 Stats.txt: " + OverwatchHomePlayer6StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Home Team Player6 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer6StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer6StatsInput);
	}

	public void OverwatchAwayDDValue(Dropdown sender)
	{
		OverwatchAwayDDStringInput = OverwatchAwayDDInput.options[OverwatchAwayDDInput.value].text;
		Debug.Log("Away Team Name.txt: " + OverwatchAwayDDStringInput);

		string path = "Assets/Games/Overwatch/Away Team Name.txt"; // This is the directory for the text file.

		if (OverwatchAwayDDStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoBlank);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (OverwatchAwayDDStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoSR);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);
		}
		if (OverwatchAwayDDStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoRIT);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (OverwatchAwayDDStringInput == "UALBANY")

		{
			string logoUA = "UA Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoUA);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (OverwatchAwayDDStringInput == "NYIT")

		{
			string logoNYIT = "NYIT Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoNYIT);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}


		if (OverwatchAwayDDStringInput == "SPU")

		{
			string logoSPU = "SPU Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoSPU);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}


		if (OverwatchAwayDDStringInput == "POLYTECHNIC")

		{
			string logoSP = "SP Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Overwatch/";

			string sourceFile = Path.Combine(sourcePath, logoSP);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (OverwatchAwayDDStringInput != "SELECT TEAM")
		{
			File.WriteAllText(path, OverwatchAwayDDStringInput); // sets the location to path and the contents to input
		}
	}

	public void OverwatchAwaySeasonRecord(string s)
	{
		string OverwatchAwaySeasonRecordInput = s;

		Debug.Log("Away Team Season Record.txt: " + OverwatchAwaySeasonRecordInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Season Record.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchAwaySeasonRecordInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchAwaySeasonRecordInput);
	}

	public void OverwatchAwaySeriesScoreIncrement()
	{
		string maxValue = "3";
		string path = "Assets/Games/Overwatch/Away Team Series Score.txt";
		if (OverwatchAwaySeriesScoreInputField != null && OverwatchAwaySeriesScoreInputField.text != maxValue)
		{
			++OverwatchAwaySeriesScoreValue;
			OverwatchAwaySeriesScoreInput = OverwatchAwaySeriesScoreValue.ToString();
			OverwatchAwaySeriesScoreInputField.text = OverwatchAwaySeriesScoreValue.ToString();
			Debug.Log("Increment - Away Team Series Score.txt: " + OverwatchAwaySeriesScoreInputField.text);
			File.WriteAllText(path, OverwatchAwaySeriesScoreInputField.text);
		}
	}

	public void OverwatchAwaySeriesScoreDecrement()
	{
		string minValue = "0";
		string path = "Assets/Games/Overwatch/Away Team Series Score.txt";
		if (OverwatchAwaySeriesScoreInputField != null && OverwatchAwaySeriesScoreInputField.text != minValue)
		{
			--OverwatchAwaySeriesScoreValue;
			OverwatchAwaySeriesScoreInput = OverwatchAwaySeriesScoreValue.ToString();
			OverwatchAwaySeriesScoreInputField.text = OverwatchAwaySeriesScoreValue.ToString();
			Debug.Log("Decrement - Away Team Series Score.txt: " + OverwatchAwaySeriesScoreInputField.text);
			File.WriteAllText(path, OverwatchAwaySeriesScoreInputField.text);
		}
	}

	public void OverwatchAwaySeriesScore(string s)
	{
		string path = "Assets/Games/Overwatch/Away Team Series Score.txt";
		OverwatchAwaySeriesScoreInput = s;
		OverwatchAwaySeriesScoreInput = OverwatchAwaySeriesScoreValue.ToString();
		OverwatchAwaySeriesScoreValue = Convert.ToInt32(OverwatchAwaySeriesScoreInputField.text);
		Debug.Log("Input - Home Team Series Score.txt: " + OverwatchAwaySeriesScoreValue);
		File.WriteAllText(path, OverwatchAwaySeriesScoreInputField.text);
	}

	public void OverwatchAwayPlayer1(string s)
	{
		string OverwatchAwayPlayer1Input = s;

		Debug.Log("Away Team Player1.txt: " + OverwatchAwayPlayer1Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchAwayPlayer1Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchAwayPlayer1Input);
	}

	public void OverwatchAwayPlayer2(string s)
	{
		string OverwatchAwayPlayer2Input = s;

		Debug.Log("Away Team Player2.txt: " + OverwatchAwayPlayer2Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchAwayPlayer2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchAwayPlayer2Input);
	}

	public void OverwatchAwayPlayer3(string s)
	{
		string OverwatchAwayPlayer3Input = s;

		Debug.Log("Away Team Player3.txt: " + OverwatchAwayPlayer3Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchAwayPlayer3Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchAwayPlayer3Input);
	}

	public void OverwatchAwayPlayer4(string s)
	{
		string OverwatchAwayPlayer4Input = s;

		Debug.Log("Away Team Player4.txt: " + OverwatchAwayPlayer4Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player4.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchAwayPlayer4Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchAwayPlayer4Input);
	}

	public void OverwatchAwayPlayer5(string s)
	{
		string OverwatchHomePlayer5Input = s;

		Debug.Log("Away Team Player5.txt: " + OverwatchHomePlayer5Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer5Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer5Input);
	}

	public void OverwatchAwayPlayer6(string s)
	{
		string OverwatchHomePlayer6Input = s;

		Debug.Log("Away Team Player6.txt: " + OverwatchHomePlayer6Input); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player6.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer6Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer6Input);
	}

	public void OverwatchAwayPlayer1Stats(string s)
	{
		string OverwatchAwayPlayer1StatsInput = s;

		Debug.Log("Away Team Player1 Stats.txt: " + OverwatchAwayPlayer1StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player1 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchAwayPlayer1StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchAwayPlayer1StatsInput);
	}

	public void OverwatchAwayPlayer2Stats(string s)
	{
		string OverwatchAwayPlayer2StatsInput = s;

		Debug.Log("Away Team Player2 Stats.txt: " + OverwatchAwayPlayer2StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player2 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchAwayPlayer2StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchAwayPlayer2StatsInput);
	}

	public void OverwatchAwayPlayer3Stats(string s)
	{
		string OverwatchAwayPlayer3StatsInput = s;

		Debug.Log("Away Team Player3 Stats.txt: " + OverwatchAwayPlayer3StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player3 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchAwayPlayer3StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchAwayPlayer3StatsInput);
	}

	public void OverwatchAwayPlayer4Stats(string s)
	{
		string OverwatchAwayPlayer4StatsInput = s;

		Debug.Log("Away Team Player4 Stats.txt: " + OverwatchAwayPlayer4StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player4 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchAwayPlayer4StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchAwayPlayer4StatsInput);
	}

	public void OverwatchAwayPlayer5Stats(string s)
	{
		string OverwatchHomePlayer5StatsInput = s;

		Debug.Log("Away Team Player5 Stats.txt: " + OverwatchHomePlayer5StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player5 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer5StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer5StatsInput);
	}

	public void OverwatchAwayPlayer6Stats(string s)
	{
		string OverwatchHomePlayer6StatsInput = s;

		Debug.Log("Away Team Player6 Stats.txt: " + OverwatchHomePlayer6StatsInput); // shows input in debug

		string path = "Assets/Games/Overwatch/Away Team Player6 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, OverwatchHomePlayer6StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, OverwatchHomePlayer6StatsInput);
	}

}
