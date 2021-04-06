using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Net;
using System.IO;

public class MainMenu : MonoBehaviour
{
	public void Valorant ()
	{
		SceneManager.LoadScene(1); // Loads specified scene
	}

	public void Overwatch ()
	{
		SceneManager.LoadScene(2); // Loads specified scene
	}

	public void SmashBros ()
	{
		SceneManager.LoadScene(3); // Loads specified scene
	}

	public void LeagueofLegends ()
	{
		SceneManager.LoadScene(4); // Loads specified scene
	}

	public void Custom ()
	{
		SceneManager.LoadScene(5); // Loads specified scene
	}

	public void Signin ()
	{
		SceneManager.LoadScene(6); // Loads specified scene
	}
	
	
	public void Signup ()
	{
		SceneManager.LoadScene(7); // Loads specified scene
	}
	
	public void Assets ()
	{
		SceneManager.LoadScene(8); // Loads specified scene
	}

	public void Quit ()
	{
		Debug.Log("Quit"); // Shows quit message in debug
		Application.Quit(); // Quits application
	}

}


public class Uploader : MonoBehaviour // We will be switching from WinSCP to AWS
{
	public string FTPHost = "66.195.8.98";
	//PLEASE KEEP IN MIND: due to campus servers own settings, if you use this program on campus, the IP needs to be 10.19.50.7
	public string FTPUserName = "winters828";
	public string FTPPassword = "712194828";
	public string FTPPort = "22"; 
	public string FilePath;

	public void UploadFile()
	{



	}

	void OnFileUploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
	{
		Debug.Log("Uploading Progreess: " + e.ProgressPercentage);
	}

	void OnFileUploadCompleted(object sender, UploadFileCompletedEventArgs e)
	{
		Debug.Log("File Uploaded");
	}

	void Start()
	{
		UploadFile();
	}
}

