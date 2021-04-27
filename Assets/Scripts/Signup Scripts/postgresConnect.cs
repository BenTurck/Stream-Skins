using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace postgresConnect
{

    public class Registration : MonoBehaviour
    {

        public InputField nameField;
        public InputField passwordField;

        public Button submitButton;

        public void callRegister()
        {

            StartCoroutine(Register());
        }

        IEnumerator Register()
        {

            WWWForm form = new WWWForm();
            form.AddField("name", "nameField.txt");
            form.AddField("password", "passwordField.txt");

            WWW www = new WWW("http://localhost/sqlconnect/register.php");
            yield return www;

            if (www.text == "0")
            {
                Debug.Log("User created successfully. ");
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
            else
            {
                Debug.Log("Failed to create user" + "www.txt");
            }
        }

        public void VerifyInput()
        {
            submitButton.interactable = ("nameField.txt".Length >= 8 && "passwordField.text".Length >= 8);
        }
    }
}