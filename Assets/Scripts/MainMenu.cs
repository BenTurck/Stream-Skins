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


