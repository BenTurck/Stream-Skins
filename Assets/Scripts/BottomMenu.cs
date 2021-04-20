using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomMenu : MonoBehaviour
{
	public void Back ()
	{
		SceneManager.LoadScene("Menu"); // Loads menu scene
	}
	public void Reset ()
	{
		Debug.Log("Reset Button"); // Debug reset
					   // work in progress
	}


	public void Quit ()
	{
		Debug.Log("Quit Button"); // Shows quit message in debug
		Application.Quit(); // Quits application
	}

}
