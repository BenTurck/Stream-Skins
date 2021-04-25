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
