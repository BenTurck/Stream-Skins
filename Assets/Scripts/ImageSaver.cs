using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class ImageSaver : MonoBehaviour
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
	
	public void ReadImageInput()
	{
		
		string fileName = "Test4.png";
		string sourcePath = "Assets/Games/Smash Bros/";
        	string targetPath = "Assets/";
		
		string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
		string destFile = System.IO.Path.Combine(targetPath, fileName);
		
		System.IO.Directory.CreateDirectory(targetPath);
		System.IO.File.Copy(sourceFile, destFile, true);

	}

}
