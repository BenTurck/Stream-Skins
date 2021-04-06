using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.IO;

public class AWS : MonoBehaviour
{
    // Login and signup stored variables
    static public string userLoginEmail;
    static public string userLoginPassword;
    static public string userSignupEmail;
    static public string userSignupPassword;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // What will happen upon clicking log in. 
    public void LoginButton()
    {
        Debug.Log(userLoginEmail);
        Debug.Log(userLoginPassword);
    }

    // What will happen upon clicking Sign up. 
    public void SignupButton()
    {
        Debug.Log(userSignupEmail);
        Debug.Log(userSignupPassword);
    }

    // Will receive login email and password information
    public void GetLoginEmail(string text)
    {

        Debug.Log("Email saved to variable!");
        userLoginEmail = text;

    }

    public void GetLoginPassword(string text)
    {
        Debug.Log("Password saved to variable!");
        userLoginPassword = text;
        
    }


    // Will receive signup email and password information 
    public void GetSignupEmail(string text)
    {

        Debug.Log("Email saved to variable!");
        userSignupEmail = text;

    }

    public void GetSignupPassword(string text)
    {

        Debug.Log("Email saved to variable!");
        userSignupPassword = text;

    }
}