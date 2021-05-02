using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class AssetsReadInput : MonoBehaviour
{
	
	private string input;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
        
	}
	
	public void ReadStringInput(string s)
	{
		input = s; // sets string input to string s
		Debug.Log(input); // shows input in debug
		
		Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates directory in this path
						// Application.streamingAssetsPath sets the directory to be in the data folder and creates folders called
						// streamingAssetsPath, LIVE_DATA, and Smash Bros
		
		string path = "Assets/Games/Smash Bros/Test1.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, input); // sets the location to path and the contents to input inside if statement
		}
		
		File.WriteAllText(path, input); // sets the location to path and the contents to input
	}

	public void ReadStringInputs(string k)
	{
		input = k; // sets string input to string s
		Debug.Log(input); // shows input in debug
		
		Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates a directory differently in this path
						
		
		string path = "Assets/Games/Smash Bros/Test2.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, input); // sets the location to path and the contents to input inside if statement
		}
		
		File.WriteAllText(path, input); // sets the location to path and the contents to input
	}
	public void ReadStringInputss(string c)
	{
		input = c; // sets string input to string s
		Debug.Log("AssetsReadInput.cs:" + input); // shows input in debug
		
		Directory.CreateDirectory("Assets/Games/Smash Bros/"); // creates a directory differently in this path
						
		
		string path = "Assets/Games/Smash Bros/Test3.txt"; // This is the directory for the text file.
		if (!File.Exists(path)) // checks if the file exists at the path
		{
			File.WriteAllText(path, input); // sets the location to path and the contents to input inside if statement
		}
		
		File.WriteAllText(path, input); // sets the location to path and the contents to input
	}
}
