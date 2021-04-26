using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class ResetSignup : MonoBehaviour
{
	public InputField clearEmail;
	public InputField clearUsername;
	public InputField clearPassword;
	public void SubmittingClear()
	{
		clearEmail.text = "";
		clearUsername.text = "";
		clearPassword.text = "";
	}
}
