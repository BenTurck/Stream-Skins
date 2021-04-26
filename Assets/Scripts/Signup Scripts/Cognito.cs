using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Extensions.CognitoAuthentication;


/*
Notes:
 * 
 * Where I left off. 
 * I need to create objects of the other class and change the dialogueManager int value
 * to reflect the message being given about the status of the sign in/ login
 * 
 * Trace through what parts tell if if the sign in was a success or not
 * 
*/
public class Cognito : MonoBehaviour
{
       
    // UI Buttons & Input Fields
    public Button LoginButton;
    public Button SignupButton;
    public InputField EmailField;
    public InputField SignupPasswordField;
    public InputField SignupUsernameField;
    public InputField LoginPasswordField;
    public InputField LoginUsernameField;
    // Token Holder
    public static string jwt;

    bool loginSuccessful;
    public bool loginScene;
    //int index; shouldn't need this but if anything breaks put it back
    public Dialogue dialogue; //This will allow you to access Dialogue class


    // Create an Identity Provider
    AmazonCognitoIdentityProviderClient provider = new AmazonCognitoIdentityProviderClient
        (new Amazon.Runtime.AnonymousAWSCredentials(), CredentialsManager.region);

    // Start is called before the first frame update
    void Start()
    {
        

        LoginButton.onClick.AddListener(Login);
        SignupButton.onClick.AddListener(Signup);


        loginSuccessful = false;
        loginScene = false; 
    }



    //The starting AWS process of pressing login
    public void Login()
    {
        _ = Login_User();

        Debug.Log("You have entered the login function");

        // Load Panels
        MenuManager.Instance.Close_Login_Panel();
        MenuManager.Instance.Load_Recommendations_Panel();
    }

    //The starting AWS process of pressing Signup
    public void Signup()
    {
        _ = Signup_Method_Async();

        Debug.Log("You have entered the signup function");
    }

    //Method that creates a new Cognito user
    private async Task Signup_Method_Async()
    {

        Debug.Log("You have entered the Signup_Method_Async function");

        Debug.Log("USERNAME FIELD = " + SignupUsernameField.text + "   PASSWORD = " + SignupPasswordField.text + "    EMAIL = " + EmailField.text );


        string userName = SignupUsernameField.text;
        string passWord = SignupPasswordField.text; //I know it sucks but at least 8 chars, spec symbol, cap and lowercase and numbers
        string email = EmailField.text;

        SignUpRequest signUpRequest = new SignUpRequest()
        {
            //requirements sent by the user
            ClientId = CredentialsManager.appClientId,
            //email = email,
            Username = userName,
            Password = passWord
        };

        List<AttributeType> attributes = new List<AttributeType>()
        {
            new AttributeType(){Name = "email", Value = email}
            //new AttributeType(){Name = "Password", Value = passWord}
        };

        signUpRequest.UserAttributes = attributes;

        //Changing our dialogue message
        DialogueManager changediag = new DialogueManager();

        try //Success
        {
            //We're going to try to make a pop up message here.

            SignUpResponse request = await provider.SignUpAsync(signUpRequest);
            Debug.Log("Sign up worked");
            TriggerDialogue(1);

            // Send signup Event 
            Events.Call_Signup();
        }
        catch (Exception e) //Failure
        {
            Debug.Log("Exception: " + e);
            TriggerDialogue(2);
            return;
        }
    }

    //Method that signs in Cognito user 
    private async Task Login_User()
    {
        string userName = LoginUsernameField.text;
        string passWord = LoginPasswordField.text;

        CognitoUserPool userPool = new CognitoUserPool(CredentialsManager.userPoolId, CredentialsManager.appClientId, provider);
        CognitoUser user = new CognitoUser(userName, CredentialsManager.appClientId, userPool, provider);

        InitiateSrpAuthRequest authRequest = new InitiateSrpAuthRequest()
        {
            Password = passWord
        };
        Debug.Log("TEST TEST TEST TEST");
        try //Something in the input fields
        {

            Debug.Log("LOGINSUCCESS = " + loginSuccessful);

            TriggerDialogue(3);
            AuthFlowResponse authResponse = await user.StartWithSrpAuthAsync(authRequest).ConfigureAwait(false);

            GetUserRequest getUserRequest = new GetUserRequest();
            getUserRequest.AccessToken = authResponse.AuthenticationResult.AccessToken;

            Debug.Log("User Access Token: " + getUserRequest.AccessToken);
            jwt = getUserRequest.AccessToken;


            // User is logged in
            loginSuccessful = true;
            loginScene = true;
            Debug.Log("LOGINSUCCESS = " + loginSuccessful);
        }
        catch (Exception e) //Nothing in the fields
        {
            TriggerDialogue(4);
            Debug.Log("Exception: " + e);
            return;
        }


        if (loginSuccessful == true)
        {
            Debug.Log("LOGINSUCCESS IN IF STATEMENT = " + loginSuccessful);
            string subId = await Get_User_Id();
            CredentialsManager.userid = subId;

            // Send Login Event
            Events.Call_Login();

            // Print UserID
            Debug.Log("Response - User's Sub ID from Cognito: " + CredentialsManager.userid);

            //streamskins added
            //loginSuccessful = false;
        }
        
    }

    // Gets a User's sub UUID from Cognito
    private async Task<string> Get_User_Id()
    {
        Debug.Log("Getting user's id...");

        string subId = "";

        Task<GetUserResponse> responseTask =
            provider.GetUserAsync(new GetUserRequest
            {
                AccessToken = jwt
            });

        GetUserResponse responseObject = await responseTask;

        // Set User ID
        foreach (var attribute in responseObject.UserAttributes)
        {
            if (attribute.Name == "sub")
            {
                subId = attribute.Value;
                break;
            }
        }

        return subId;

    }
    //Part of direction 1
    //Triggers Dialogue box after information is handled in Cognito
    public void TriggerDialogue(int mesIndex)
    {
        Debug.Log("Inside TriggerDialogue");
        //The trigger calls on the dialong script onclick 
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue,mesIndex);
    }
    //

}//End of class
