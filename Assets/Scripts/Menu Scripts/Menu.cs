using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Net;
using System.IO;

public class Menu : MonoBehaviour
{
	public void Valorant ()
	{
		SceneManager.LoadScene("Valorant"); // Loads specified scene
	}

	public void Overwatch ()
	{
		SceneManager.LoadScene("Overwatch"); // Loads specified scene
	}

	public void SmashBros ()
	{
		SceneManager.LoadScene("SmashBros"); // Loads specified scene
	}

	public void LeagueofLegends ()
	{
		SceneManager.LoadScene("LeagueofLegends"); // Loads specified scene
	}

	public void Custom ()
	{
		SceneManager.LoadScene("Custom"); // Loads specified scene
	}

	public void Signin ()
	{
		SceneManager.LoadScene("Signin"); // Loads specified scene
	}
	
	public void Signup ()
	{
		SceneManager.LoadScene("Signup"); // Loads specified scene
	}
	public void Stats()
	{
		SceneManager.LoadScene("Stats"); // Loads specified scene
	}
	public void Assets ()
	{
		SceneManager.LoadScene("Assets"); // Loads specified scene
	}
	public void Back()
	{
		SceneManager.LoadScene("Menu"); // Loads menu scene
	}
	public void Quit ()
	{
		Debug.Log("Quit"); // Shows quit message in debug
		Application.Quit(); // Quits application
	}

}


