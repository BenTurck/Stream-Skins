using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Amazon.DynamoDBv2;

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

		string path = "Assets/Games/Valorant/Caster2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantCaster2Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantCaster2Input);
	}

	public void ValorantGame1DDValue(Dropdown sender)
    {
		ValorantGame1DDStringInput = ValorantGame1DDInput.options[ValorantGame1DDInput.value].text;

		string path1 = "Assets/Games/Valorant/Map1 Name.txt";


		string map1Blank = "Blank.png";
		string map1Ascent = "Valorant Ascent.png";
		string map1Bind = "Valorant Bind.png";
		string map1Breeze = "Valorant Breeze.png";
		string map1Haven = "Valorant Haven.png";
		string map1Icebox = "Valorant Icebox.png";
		string map1Split = "Valorant Split.png";


		string map1 = "Map 1.png";
		string sourceMap1Path = "Assets/GameMaps/";
		string targetMap1Path = "Assets/Games/Valorant/";

		string sourceMap1BlankFile = Path.Combine(sourceMap1Path, map1Blank);
		string sourceMap1AscentFile = Path.Combine(sourceMap1Path, map1Ascent);
		string sourceMap1BindFile = Path.Combine(sourceMap1Path, map1Bind);
		string sourceMap1BreezeFile = Path.Combine(sourceMap1Path, map1Breeze);
		string sourceMap1HavenFile = Path.Combine(sourceMap1Path, map1Haven);
		string sourceMap1IceboxFile = Path.Combine(sourceMap1Path, map1Icebox);
		string sourceMap1SplitFile = Path.Combine(sourceMap1Path, map1Split);

		string destMap1File = Path.Combine(targetMap1Path, map1);

		if (ValorantGame1DDStringInput == "SELECT MAP 1")
        {
			File.Copy(sourceMap1BlankFile, destMap1File, true);
			File.WriteAllText(path1, "");
			Debug.Log("Map1 Name.txt: ");
		}

		if (ValorantGame1DDStringInput == "ASCENT")
        {
			File.Copy(sourceMap1AscentFile, destMap1File, true);
			File.WriteAllText(path1, ValorantGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + ValorantGame1DDStringInput);
		}

		if (ValorantGame1DDStringInput == "BIND")
		{
			File.Copy(sourceMap1BindFile, destMap1File, true);
			File.WriteAllText(path1, ValorantGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + ValorantGame1DDStringInput);
		}

		if (ValorantGame1DDStringInput == "BREEZE")
		{
			File.Copy(sourceMap1BreezeFile, destMap1File, true);
			File.WriteAllText(path1, ValorantGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + ValorantGame1DDStringInput);
		}

		if (ValorantGame1DDStringInput == "HAVEN")
		{
			File.Copy(sourceMap1HavenFile, destMap1File, true);
			File.WriteAllText(path1, ValorantGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + ValorantGame1DDStringInput);
		}

		if (ValorantGame1DDStringInput == "ICEBOX")
		{
			File.Copy(sourceMap1IceboxFile, destMap1File, true);
			File.WriteAllText(path1, ValorantGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + ValorantGame1DDStringInput);
		}

		if (ValorantGame1DDStringInput == "SPLIT")
		{
			File.Copy(sourceMap1SplitFile, destMap1File, true);
			File.WriteAllText(path1, ValorantGame1DDStringInput);
			Debug.Log("Map1 Name.txt: " + ValorantGame1DDStringInput);
		}
	}

	public void ValorantGame2DDValue(Dropdown sender)
	{
		ValorantGame2DDStringInput = ValorantGame2DDInput.options[ValorantGame2DDInput.value].text;

		string path2 = "Assets/Games/Valorant/Map2 Name.txt";


		string map2Blank = "Blank.png";
		string map2Ascent = "Valorant Ascent.png";
		string map2Bind = "Valorant Bind.png";
		string map2Breeze = "Valorant Breeze.png";
		string map2Haven = "Valorant Haven.png";
		string map2Icebox = "Valorant Icebox.png";
		string map2Split = "Valorant Split.png";


		string map2 = "Map 2.png";
		string sourceMap2Path = "Assets/GameMaps/";
		string targetMap2Path = "Assets/Games/Valorant/";

		string sourceMap2BlankFile = Path.Combine(sourceMap2Path, map2Blank);
		string sourceMap2AscentFile = Path.Combine(sourceMap2Path, map2Ascent);
		string sourceMap2BindFile = Path.Combine(sourceMap2Path, map2Bind);
		string sourceMap2BreezeFile = Path.Combine(sourceMap2Path, map2Breeze);
		string sourceMap2HavenFile = Path.Combine(sourceMap2Path, map2Haven);
		string sourceMap2IceboxFile = Path.Combine(sourceMap2Path, map2Icebox);
		string sourceMap2SplitFile = Path.Combine(sourceMap2Path, map2Split);

		string destMap2File = Path.Combine(targetMap2Path, map2);

		if (ValorantGame2DDStringInput == "SELECT MAP 2")
		{
			File.Copy(sourceMap2BlankFile, destMap2File, true);
			File.WriteAllText(path2, "");
			Debug.Log("Map2 Name.txt: ");
		}

		if (ValorantGame2DDStringInput == "ASCENT")
		{
			File.Copy(sourceMap2AscentFile, destMap2File, true);
			File.WriteAllText(path2, ValorantGame2DDStringInput);
			Debug.Log("Map2 Name.txt: " + ValorantGame2DDStringInput);
		}

		if (ValorantGame2DDStringInput == "BIND")
		{
			File.Copy(sourceMap2BindFile, destMap2File, true);
			File.WriteAllText(path2, ValorantGame2DDStringInput);
			Debug.Log("Map2 Name.txt: " + ValorantGame2DDStringInput);
		}

		if (ValorantGame2DDStringInput == "BREEZE")
		{
			File.Copy(sourceMap2BreezeFile, destMap2File, true);
			File.WriteAllText(path2, ValorantGame2DDStringInput);
			Debug.Log("Map2 Name.txt: " + ValorantGame2DDStringInput);
		}

		if (ValorantGame2DDStringInput == "HAVEN")
		{
			File.Copy(sourceMap2HavenFile, destMap2File, true);
			File.WriteAllText(path2, ValorantGame2DDStringInput);
			Debug.Log("Map2 Name.txt: " + ValorantGame2DDStringInput);
		}

		if (ValorantGame2DDStringInput == "ICEBOX")
		{
			File.Copy(sourceMap2IceboxFile, destMap2File, true);
			File.WriteAllText(path2, ValorantGame2DDStringInput);
			Debug.Log("Map2 Name.txt: " + ValorantGame2DDStringInput);
		}

		if (ValorantGame2DDStringInput == "SPLIT")
		{
			File.Copy(sourceMap2SplitFile, destMap2File, true);
			File.WriteAllText(path2, ValorantGame2DDStringInput);
			Debug.Log("Map2 Name.txt: " + ValorantGame2DDStringInput);
		}
	}

	public void ValorantGame3DDValue(Dropdown sender)
	{
		ValorantGame3DDStringInput = ValorantGame3DDInput.options[ValorantGame3DDInput.value].text;

		string path3 = "Assets/Games/Valorant/Map3 Name.txt";


		string map3Blank = "Blank.png";
		string map3Ascent = "Valorant Ascent.png";
		string map3Bind = "Valorant Bind.png";
		string map3Breeze = "Valorant Breeze.png";
		string map3Haven = "Valorant Haven.png";
		string map3Icebox = "Valorant Icebox.png";
		string map3Split = "Valorant Split.png";


		string map3 = "Map 3.png";
		string sourceMap3Path = "Assets/GameMaps/";
		string targetMap3Path = "Assets/Games/Valorant/";

		string sourceMap3BlankFile = Path.Combine(sourceMap3Path, map3Blank);
		string sourceMap3AscentFile = Path.Combine(sourceMap3Path, map3Ascent);
		string sourceMap3BindFile = Path.Combine(sourceMap3Path, map3Bind);
		string sourceMap3BreezeFile = Path.Combine(sourceMap3Path, map3Breeze);
		string sourceMap3HavenFile = Path.Combine(sourceMap3Path, map3Haven);
		string sourceMap3IceboxFile = Path.Combine(sourceMap3Path, map3Icebox);
		string sourceMap3SplitFile = Path.Combine(sourceMap3Path, map3Split);

		string destMap3File = Path.Combine(targetMap3Path, map3);

		if (ValorantGame3DDStringInput == "SELECT MAP 3")
		{
			File.Copy(sourceMap3BlankFile, destMap3File, true);
			File.WriteAllText(path3, "");
			Debug.Log("Map3 Name.txt: ");
		}

		if (ValorantGame3DDStringInput == "ASCENT")
		{
			File.Copy(sourceMap3AscentFile, destMap3File, true);
			File.WriteAllText(path3, ValorantGame3DDStringInput);
			Debug.Log("Map3 Name.txt: " + ValorantGame3DDStringInput);
		}

		if (ValorantGame3DDStringInput == "BIND")
		{
			File.Copy(sourceMap3BindFile, destMap3File, true);
			File.WriteAllText(path3, ValorantGame3DDStringInput);
			Debug.Log("Map3 Name.txt: " + ValorantGame3DDStringInput);
		}

		if (ValorantGame3DDStringInput == "BREEZE")
		{
			File.Copy(sourceMap3BreezeFile, destMap3File, true);
			File.WriteAllText(path3, ValorantGame3DDStringInput);
			Debug.Log("Map3 Name.txt: " + ValorantGame3DDStringInput);
		}

		if (ValorantGame3DDStringInput == "HAVEN")
		{
			File.Copy(sourceMap3HavenFile, destMap3File, true);
			File.WriteAllText(path3, ValorantGame3DDStringInput);
			Debug.Log("Map3 Name.txt: " + ValorantGame3DDStringInput);
		}

		if (ValorantGame3DDStringInput == "ICEBOX")
		{
			File.Copy(sourceMap3IceboxFile, destMap3File, true);
			File.WriteAllText(path3, ValorantGame3DDStringInput);
			Debug.Log("Map3 Name.txt: " + ValorantGame3DDStringInput);
		}

		if (ValorantGame3DDStringInput == "SPLIT")
		{
			File.Copy(sourceMap3SplitFile, destMap3File, true);
			File.WriteAllText(path3, ValorantGame3DDStringInput);
			Debug.Log("Map3 Name.txt: " + ValorantGame3DDStringInput);
		}
	}

	public void ValorantGame4DDValue(Dropdown sender)
	{
		ValorantGame4DDStringInput = ValorantGame4DDInput.options[ValorantGame4DDInput.value].text;

		string path4 = "Assets/Games/Valorant/Map4 Name.txt";


		string map4Blank = "Blank.png";
		string map4Ascent = "Valorant Ascent.png";
		string map4Bind = "Valorant Bind.png";
		string map4Breeze = "Valorant Breeze.png";
		string map4Haven = "Valorant Haven.png";
		string map4Icebox = "Valorant Icebox.png";
		string map4Split = "Valorant Split.png";


		string map4 = "Map 4.png";
		string sourceMap4Path = "Assets/GameMaps/";
		string targetMap4Path = "Assets/Games/Valorant/";

		string sourceMap4BlankFile = Path.Combine(sourceMap4Path, map4Blank);
		string sourceMap4AscentFile = Path.Combine(sourceMap4Path, map4Ascent);
		string sourceMap4BindFile = Path.Combine(sourceMap4Path, map4Bind);
		string sourceMap4BreezeFile = Path.Combine(sourceMap4Path, map4Breeze);
		string sourceMap4HavenFile = Path.Combine(sourceMap4Path, map4Haven);
		string sourceMap4IceboxFile = Path.Combine(sourceMap4Path, map4Icebox);
		string sourceMap4SplitFile = Path.Combine(sourceMap4Path, map4Split);

		string destMap4File = Path.Combine(targetMap4Path, map4);

		if (ValorantGame4DDStringInput == "SELECT MAP 4")
		{
			File.Copy(sourceMap4BlankFile, destMap4File, true);
			File.WriteAllText(path4, "");
			Debug.Log("Map4 Name.txt: ");
		}

		if (ValorantGame4DDStringInput == "ASCENT")
		{
			File.Copy(sourceMap4AscentFile, destMap4File, true);
			File.WriteAllText(path4, ValorantGame4DDStringInput);
			Debug.Log("Map4 Name.txt: " + ValorantGame4DDStringInput);
		}

		if (ValorantGame4DDStringInput == "BIND")
		{
			File.Copy(sourceMap4BindFile, destMap4File, true);
			File.WriteAllText(path4, ValorantGame4DDStringInput);
			Debug.Log("Map4 Name.txt: " + ValorantGame4DDStringInput);
		}

		if (ValorantGame4DDStringInput == "BREEZE")
		{
			File.Copy(sourceMap4BreezeFile, destMap4File, true);
			File.WriteAllText(path4, ValorantGame4DDStringInput);
			Debug.Log("Map4 Name.txt: " + ValorantGame4DDStringInput);
		}

		if (ValorantGame4DDStringInput == "HAVEN")
		{
			File.Copy(sourceMap4HavenFile, destMap4File, true);
			File.WriteAllText(path4, ValorantGame4DDStringInput);
			Debug.Log("Map4 Name.txt: " + ValorantGame4DDStringInput);
		}

		if (ValorantGame4DDStringInput == "ICEBOX")
		{
			File.Copy(sourceMap4IceboxFile, destMap4File, true);
			File.WriteAllText(path4, ValorantGame4DDStringInput);
			Debug.Log("Map4 Name.txt: " + ValorantGame4DDStringInput);
		}

		if (ValorantGame4DDStringInput == "SPLIT")
		{
			File.Copy(sourceMap4SplitFile, destMap4File, true);
			File.WriteAllText(path4, ValorantGame4DDStringInput);
			Debug.Log("Map4 Name.txt: " + ValorantGame4DDStringInput);
		}
	}

	public void ValorantGame5DDValue(Dropdown sender)
	{
		ValorantGame5DDStringInput = ValorantGame5DDInput.options[ValorantGame5DDInput.value].text;

		string path5 = "Assets/Games/Valorant/Map5 Name.txt";


		string map5Blank = "Blank.png";
		string map5Ascent = "Valorant Ascent.png";
		string map5Bind = "Valorant Bind.png";
		string map5Breeze = "Valorant Breeze.png";
		string map5Haven = "Valorant Haven.png";
		string map5Icebox = "Valorant Icebox.png";
		string map5Split = "Valorant Split.png";


		string map5 = "Map 5.png";
		string sourceMap5Path = "Assets/GameMaps/";
		string targetMap5Path = "Assets/Games/Valorant/";

		string sourceMap5BlankFile = Path.Combine(sourceMap5Path, map5Blank);
		string sourceMap5AscentFile = Path.Combine(sourceMap5Path, map5Ascent);
		string sourceMap5BindFile = Path.Combine(sourceMap5Path, map5Bind);
		string sourceMap5BreezeFile = Path.Combine(sourceMap5Path, map5Breeze);
		string sourceMap5HavenFile = Path.Combine(sourceMap5Path, map5Haven);
		string sourceMap5IceboxFile = Path.Combine(sourceMap5Path, map5Icebox);
		string sourceMap5SplitFile = Path.Combine(sourceMap5Path, map5Split);

		string destMap5File = Path.Combine(targetMap5Path, map5);

		if (ValorantGame5DDStringInput == "SELECT MAP 5")
		{
			File.Copy(sourceMap5BlankFile, destMap5File, true);
			File.WriteAllText(path5, "");
			Debug.Log("Map5 Name.txt: ");
		}

		if (ValorantGame5DDStringInput == "ASCENT")
		{
			File.Copy(sourceMap5AscentFile, destMap5File, true);
			File.WriteAllText(path5, ValorantGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + ValorantGame5DDStringInput);
		}

		if (ValorantGame5DDStringInput == "BIND")
		{
			File.Copy(sourceMap5BindFile, destMap5File, true);
			File.WriteAllText(path5, ValorantGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + ValorantGame5DDStringInput);
		}

		if (ValorantGame5DDStringInput == "BREEZE")
		{
			File.Copy(sourceMap5BreezeFile, destMap5File, true);
			File.WriteAllText(path5, ValorantGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + ValorantGame5DDStringInput);
		}

		if (ValorantGame5DDStringInput == "HAVEN")
		{
			File.Copy(sourceMap5HavenFile, destMap5File, true);
			File.WriteAllText(path5, ValorantGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + ValorantGame5DDStringInput);
		}

		if (ValorantGame5DDStringInput == "ICEBOX")
		{
			File.Copy(sourceMap5IceboxFile, destMap5File, true);
			File.WriteAllText(path5, ValorantGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + ValorantGame5DDStringInput);
		}

		if (ValorantGame5DDStringInput == "SPLIT")
		{
			File.Copy(sourceMap5SplitFile, destMap5File, true);
			File.WriteAllText(path5, ValorantGame5DDStringInput);
			Debug.Log("Map5 Name.txt: " + ValorantGame5DDStringInput);
		}
	}

	public void ValorantHomeGame1Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game1 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 1 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Valorant/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 1 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Valorant/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (ValorantAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + ValorantHomeDDStringInput + text2);
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

	public void ValorantHomeGame2Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game2 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 2 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Valorant/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 2 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Valorant/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (ValorantAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + ValorantHomeDDStringInput + text2);
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

	public void ValorantHomeGame3Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game3 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 3 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Valorant/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 3 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Valorant/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (ValorantAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + ValorantHomeDDStringInput + text2);
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

	public void ValorantHomeGame4Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game4 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 4 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Valorant/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 4 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Valorant/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (ValorantAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + ValorantHomeDDStringInput + text2);
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

	public void ValorantHomeGame5Toggle(bool tog)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantHomeDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game5 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 5 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Valorant/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoHome = "Home Logo.png";
		string logoWinner = "Map 5 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Valorant/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoHomeFile = Path.Combine(targetLogoPath, logoHome);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (ValorantAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + ValorantHomeDDStringInput + text2);
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

	public void ValorantGame1Score(string s)
	{
		string ValorantGame1ScoreInput = s;

		Debug.Log("Game1 Score.txt: " + ValorantGame1ScoreInput); // shows input in debug

		string path = "Assets/Games/Valorant/Game1 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantGame1ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantGame1ScoreInput);

	}

	public void ValorantGame2Score(string s)
	{
		string ValorantGame2ScoreInput = s;

		Debug.Log("Game2 Score.txt: " + ValorantGame2ScoreInput); // shows input in debug

		string path = "Assets/Games/Valorant/Game2 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantGame2ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantGame2ScoreInput);
	}

	public void ValorantGame3Score(string s)
	{
		string ValorantGame3ScoreInput = s;

		Debug.Log("Game3 Score.txt: " + ValorantGame3ScoreInput); // shows input in debug

		string path = "Assets/Games/Valorant/Game3 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantGame3ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantGame3ScoreInput);
	}

	public void ValorantGame4Score(string s)
	{
		string ValorantGame4ScoreInput = s;

		Debug.Log("Game4 Score.txt: " + ValorantGame4ScoreInput); // shows input in debug

		string path = "Assets/Games/Valorant/Game4 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantGame4ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantGame4ScoreInput);
	}

	public void ValorantGame5Score(string s)
	{
		string ValorantGame5ScoreInput = s;

		Debug.Log("Game5 Score.txt: " + ValorantGame5ScoreInput); // shows input in debug

		string path = "Assets/Games/Valorant/Game5 Score.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantGame5ScoreInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantGame5ScoreInput);
	}

	public void ValorantAwayGame1Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Game1 Winner.txt: " + tog);
		string text1 = "Game 1: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game1 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 1 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Valorant/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 1 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Valorant/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (ValorantAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + ValorantAwayDDStringInput + text2);
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

	public void ValorantAwayGame2Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Game2 Winner.txt: " + tog);
		string text1 = "Game 2: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game2 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 2 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Valorant/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 2 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Valorant/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (ValorantAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + ValorantAwayDDStringInput + text2);
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

	public void ValorantAwayGame3Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Game3 Winner.txt: " + tog);
		string text1 = "Game 3: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game3 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 3 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Valorant/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 3 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Valorant/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (ValorantAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + ValorantAwayDDStringInput + text2);
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

	public void ValorantAwayGame4Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Game4 Winner.txt: " + tog);
		string text1 = "Game 4: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game4 Winner.txt";


		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 4 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Valorant/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 4 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Valorant/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (ValorantAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + ValorantAwayDDStringInput + text2);
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

	public void ValorantAwayGame5Toggle(bool tog)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Game5 Winner.txt: " + tog);
		string text1 = "Game 5: ";
		string text2 = " Won";
		string bothinput = text1 + ValorantAwayDDStringInput + text2;
		string path = "Assets/Games/Valorant/Game5 Winner.txt";

		string mapBlank = "Blank.png";
		string mapPlayed = "Map Played.png";
		string mapWinner = "Map 5 Played.png";
		string sourceMapPath = "Assets/GameMaps/";
		string targetMapPath = "Assets/Games/Valorant/";

		string sourceMapBlankFile = Path.Combine(sourceMapPath, mapBlank);
		string sourceMapPlayedFile = Path.Combine(sourceMapPath, mapPlayed);
		string destMapFile = Path.Combine(targetMapPath, mapWinner);

		string logoBlank = "Blank.png";
		string logoAway = "Away Logo.png";
		string logoWinner = "Map 5 Winner.png";
		string sourceLogoPath = "Assets/TeamLogos/";
		string targetLogoPath = "Assets/Games/Valorant/";

		string sourceLogoBlankFile = Path.Combine(sourceLogoPath, logoBlank);
		string sourceLogoAwayFile = Path.Combine(targetLogoPath, logoAway);
		string destLogoFile = Path.Combine(targetLogoPath, logoWinner);




		if (ValorantAwayDDStringInput == "SELECT TEAM")
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
				Debug.Log(text1 + ValorantAwayDDStringInput + text2);
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

	public void ValorantHomeDDValue(Dropdown sender)
	{
		ValorantHomeDDStringInput = ValorantHomeDDInput.options[ValorantHomeDDInput.value].text;
		Debug.Log("Home Team Name.txt: " + ValorantHomeDDStringInput);

		string path = "Assets/Games/Valorant/Home Team Name.txt"; // This is the directory for the text file.

		if (ValorantHomeDDStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoBlank);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (ValorantHomeDDStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoSR);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);
		}
		if (ValorantHomeDDStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoRIT);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (ValorantHomeDDStringInput == "UALBANY")

		{
			string logoUA = "UA Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoUA);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (ValorantHomeDDStringInput == "NYIT")

		{
			string logoNYIT = "NYIT Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoNYIT);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (ValorantHomeDDStringInput == "SPU")

		{
			string logoSPU = "SPU Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoSPU);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

		}

		if (ValorantHomeDDStringInput == "POLYTECHNIC")

		{
			string logoSP = "SP Logo.png";
			string logoHome = "Home Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoSP);
			string destFile = Path.Combine(targetPath, logoHome);

			File.Copy(sourceFile, destFile, true);

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

		string path = "Assets/Games/Valorant/Home Team Player5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer5Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer5Input);
	}

	public void ValorantHomePlayer1Stats(string s)
	{
		string ValorantHomePlayer1StatsInput = s;

		Debug.Log("Home Team Player1 Stats.txt: " + ValorantHomePlayer1StatsInput); // shows input in debug

		string path = "Assets/Games/Valorant/Home Team Player1 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer1StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer1StatsInput);
	}

	public void ValorantHomePlayer2Stats(string s)
	{
		string ValorantHomePlayer2StatsInput = s;

		Debug.Log("Home Team Player2 Stats.txt: " + ValorantHomePlayer2StatsInput); // shows input in debug

		string path = "Assets/Games/Valorant/Home Team Player2 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer2StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer2StatsInput);
	}

	public void ValorantHomePlayer3Stats(string s)
	{
		string ValorantHomePlayer3StatsInput = s;

		Debug.Log("Home Team Player3 Stats.txt: " + ValorantHomePlayer3StatsInput); // shows input in debug

		string path = "Assets/Games/Valorant/Home Team Player3 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer3StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer3StatsInput);
	}

	public void ValorantHomePlayer4Stats(string s)
	{
		string ValorantHomePlayer4StatsInput = s;

		Debug.Log("Home Team Player4 Stats.txt: " + ValorantHomePlayer4StatsInput); // shows input in debug

		string path = "Assets/Games/Valorant/Home Team Player4 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer4StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer4StatsInput);
	}

	public void ValorantHomePlayer5Stats(string s)
	{
		string ValorantHomePlayer5StatsInput = s;

		Debug.Log("Home Team Player5 Stats.txt: " + ValorantHomePlayer5StatsInput); // shows input in debug

		string path = "Assets/Games/Valorant/Home Team Player5 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer5StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer5StatsInput);
	}

	public void ValorantAwayDDValue(Dropdown sender)
	{
		ValorantAwayDDStringInput = ValorantAwayDDInput.options[ValorantAwayDDInput.value].text;
		Debug.Log("Away Team Name.txt: " + ValorantAwayDDStringInput);

		string path = "Assets/Games/Valorant/Away Team Name.txt"; // This is the directory for the text file.

		if (ValorantAwayDDStringInput == "SELECT TEAM")
		{
			string logoBlank = "Blank.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoBlank);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);
			File.WriteAllText(path, ""); // sets the location to path and the contents to input
		}

		if (ValorantAwayDDStringInput == "SAINT ROSE")
		{
			string logoSR = "SR LOGO.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoSR);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);
		}
		if (ValorantAwayDDStringInput == "RIT")

		{
			string logoRIT = "RIT Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoRIT);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (ValorantAwayDDStringInput == "UALBANY")

		{
			string logoUA = "UA Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoUA);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}

		if (ValorantAwayDDStringInput == "NYIT")

		{
			string logoNYIT = "NYIT Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoNYIT);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}


		if (ValorantAwayDDStringInput == "SPU")

		{
			string logoSPU = "SPU Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoSPU);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

		}


		if (ValorantAwayDDStringInput == "POLYTECHNIC")

		{
			string logoSP = "SP Logo.png";
			string logoAway = "Away Logo.png";
			string sourcePath = "Assets/TeamLogos/";
			string targetPath = "Assets/Games/Valorant/";

			string sourceFile = Path.Combine(sourcePath, logoSP);
			string destFile = Path.Combine(targetPath, logoAway);

			File.Copy(sourceFile, destFile, true);

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

		string path = "Assets/Games/Valorant/Away Team Player5.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer5Input); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer5Input);
	}

	public void ValorantAwayPlayer1Stats(string s)
	{
		string ValorantAwayPlayer1StatsInput = s;

		Debug.Log("Away Team Player1 Stats.txt: " + ValorantAwayPlayer1StatsInput); // shows input in debug

		string path = "Assets/Games/Valorant/Away Team Player1 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayPlayer1StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayPlayer1StatsInput);
	}

	public void ValorantAwayPlayer2Stats(string s)
	{
		string ValorantAwayPlayer2StatsInput = s;

		Debug.Log("Away Team Player2 Stats.txt: " + ValorantAwayPlayer2StatsInput); // shows input in debug

		string path = "Assets/Games/Valorant/Away Team Player2 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayPlayer2StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayPlayer2StatsInput);
	}

	public void ValorantAwayPlayer3Stats(string s)
	{
		string ValorantAwayPlayer3StatsInput = s;

		Debug.Log("Away Team Player3 Stats.txt: " + ValorantAwayPlayer3StatsInput); // shows input in debug

		string path = "Assets/Games/Valorant/Away Team Player3 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayPlayer3StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayPlayer3StatsInput);
	}

	public void ValorantAwayPlayer4Stats(string s)
	{
		string ValorantAwayPlayer4StatsInput = s;

		Debug.Log("Away Team Player4 Stats.txt: " + ValorantAwayPlayer4StatsInput); // shows input in debug

		string path = "Assets/Games/Valorant/Away Team Player4 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantAwayPlayer4StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantAwayPlayer4StatsInput);
	}

	public void ValorantAwayPlayer5Stats(string s)
	{
		string ValorantHomePlayer5StatsInput = s;

		Debug.Log("Away Team Player5 Stats.txt: " + ValorantHomePlayer5StatsInput); // shows input in debug

		string path = "Assets/Games/Valorant/Away Team Player5 Stats.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, ValorantHomePlayer5StatsInput); // sets the location to path and the contents to input inside if statement
		}

		File.WriteAllText(path, ValorantHomePlayer5StatsInput);
	}

}
