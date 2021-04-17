using System.Collections;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text headertext;
    public Text bodytext;
    public Vector3 pos;
    public bool down = true;

    //To be used to reference status in Cognito 
    // 1 = sign up success | 2 = sign up exception | 3 = login success | 4 = login failure 
    public int DBN = 0; //used to set Dialogue Box Number
    string passedE;

    //SHOULD HAVE BEEN OBVIOUS START DIALOGUE STARTS RIGHT AWAY.
    //PUT IT IN ITS OWN METHOD AND CALL IT INSTEAD OF STARTDIALOGUE

    //What happens when the trigger is triggered (login or sign up button)
    public void StartDialogue(Dialogue dialogue)
    {

        Debug.Log("Start of StartDialogue class");

        //Change to proper text depending on what Cognito Class sets
        if(DBN == 1)
        {signupsucc();
        } else if(DBN == 2)
        {signupfail(); //Try to be more speicifc with these ones
        } else if (DBN == 3)
        {loginsucc();
        } else if (DBN == 4)
        {//loginfail(); //Try to be more speicifc with these ones
        }
        else if (DBN == 0)
        {
            Debug.Log("ERROR: DBN=0 COGNITO SCRIPT WAS UNABLE TO REACH DIALOGUEMANAGER IN TIME TO CHANGE THE TEXT");
        }
        

        //This will control the movement of the dialogue box
        if (down) //If it's down it needs to pop up with a message 
            popup();
        

        

    }// End of StartDialogue 

    public void ttest(string tdata)
    {
        Debug.Log(tdata);

    }

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
    }

    public void signupfail()
    {

        //If SIGN UP has FAILED
        //Please note, there may be different reasons for sign up failure.
        headertext.text = "Sign up failed";
        bodytext.text = "";//e.ToString(); //This may branch out into different messages. 
    }

    public void loginsucc()
    {
        //If LOGIN has SUCCEEDED
        headertext.text = "Login succeeded!";
        bodytext.text = "You've successfully logged in.\nYou may now access statistics editor."; //This may branch out into different messages. 
    }

    public void loginfail()
    {
        //If LOGIN has FAILED 
        headertext.text = "Login failed";
        bodytext.text = "Please check to make sure your password is right and try again.";
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







/*  An alternative to creating a more intuitive changeing dialogue box.
 *  Use if you need to do more than just manipulate a single string in this script
  
    //A Queue of type string 
    //This was apart of the guide so it's nice but
    //a queue of strings isn't even necessary.
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        //This would change depending on the message sent.
        headertext.text = "Change, depends on message";
        
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count==0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        bodytext.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");

    }
*/