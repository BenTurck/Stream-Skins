using System;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text headertext;
    public Text bodytext;
    public Vector3 pos;
    public bool down = true;
    public Text username;

    //To be used to reference status in Cognito 
    // 1 = sign up success | 2 = sign up exception | 3 = login success | 4 = login failure 
    
    //DELETE IF NOT USED
    public int DBN = 0; //used to set Dialogue Box Number
    string passedE;

    //SHOULD HAVE BEEN OBVIOUS START DIALOGUE STARTS RIGHT AWAY.

    //What happens when the trigger is triggered (login or sign up button)
    public void StartDialogue(Dialogue dialogue,int mesIndex)
    {

        //Debug.Log("START DIALOGUE BOOLEAN VALUE = " + test);

        //This will control the movement of the dialogue box
        if (down) //If it's down it needs to pop up with a message 
            popup();


        Debug.Log("WE MADE IT PAST THE IF DOWN STATEMENT");
        
        //Change to proper text depending on what Cognito Class sets
        if (mesIndex == 1)
        {
            signupsucc();
        }
        else if (mesIndex == 2)
        {
            signupfail(); //Try to be more speicifc with these ones
        }
        else if (mesIndex == 3) //Login success 
        {
            PlayerPrefs.SetInt("all", 3);
            loginsucc();
        }
        else if (mesIndex == 4) //Login fail 
        {
            PlayerPrefs.SetInt("all", 4);
            loginfail(); //Try to be more speicifc with these ones
        }
        else
        {
            Debug.Log("ERROR: DBN=0 COGNITO SCRIPT WAS UNABLE TO REACH DIALOGUEMANAGER IN TIME TO CHANGE THE TEXT");
        }



    }// End of StartDialogue 

    public void popup()
    {
        down = false;

        //Pop up will need a place to update and set the proper message that pops up
        //right here...

        //You need to take pos out, change it and put it back in.
        pos = transform.position;
        //Debug.Log("Position: " + pos);
        pos.y += 850;
        transform.position = pos;
    }

    //aka going down
    public void contbutton()
    {
        down = true;

        pos = transform.position;
        //Debug.Log("Position: " + pos);
        pos.y += -850;
        transform.position = pos;

    }


    //---------------- Change Dialogue box text ------------------------------------
    
    public void signupsucc()
    {
        //If SIGN UP was SUCCESSFUL 
        headertext.text = "Sign up successful!";
        bodytext.text = "Your sign up has gone through! \nPlease check your email's inbox";
        return;
    }

    public void signupfail()
    {

        //If SIGN UP has FAILED
        headertext.text = "Sign up failed";
        bodytext.text = "With a sign up failure \nyou may want to check the requirements below";//e.ToString(); //This may branch out into different messages. 
        return;
    }

    public void loginsucc()
    {
        //If LOGIN has SUCCEEDED
        headertext.text = "Login succeeded!";
        bodytext.text = "You've successfully logged in.\nYou may now access the statistics editor."; //This may branch out into different messages. 
        return;
    }

    public void loginfail()
    {
        //If LOGIN has FAILED 
        headertext.text = "Login failed";
        bodytext.text = "Please check to make sure your information is right and try again.";
        return;
    }

    //---------------- Setters and Getters ------------------------------------

    //MAY NOT NEED THESE
    //Mutators
    public void setDBN(int DBN)
    {
        this.DBN = DBN; 
    }

    public void setException(int DBN, Exception e)
    {
        this.DBN = DBN;
        passedE = e.ToString();
    }

    //Accessor
    public int getDBN()
    {
        return DBN;
    }
    

}// End of class
