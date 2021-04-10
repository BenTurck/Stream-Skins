using System;
using UnityEngine;
using Amazon;
using Amazon.CognitoIdentity;


public class CredentialsManager
{

    // Region - A game may need multiple region endpoints if services
    // are in multiple regions or different per service
    public static RegionEndpoint region = RegionEndpoint.USEast2;
    // Please note that you may have to recheck the region endpoint.

    // Cognito Credentials Variables
    public const string identityPool = "us-east-2:a4ab9b92-c2b6-4862-9659-72afb73baa68";
    public static string userPoolId = "us-east-2_g3AZifJpC";
    public static string appClientId = "ak0s648o4vf8mc7hcakvlcnsi";

    // Initialize the Amazon Cognito credentials provider
    public static CognitoAWSCredentials credentials = new CognitoAWSCredentials(
        identityPool, region
    );

    // User's Cognito ID once logged in becomes set here
    public static string userid = "";

}
