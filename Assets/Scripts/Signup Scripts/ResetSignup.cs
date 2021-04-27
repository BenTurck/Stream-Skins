using UnityEngine;
using UnityEngine.UI;

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
