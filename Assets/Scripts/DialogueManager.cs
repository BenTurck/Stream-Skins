using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text headertext;
    public Text bodytext;
    public Vector3 pos;
    public bool down = true;

    public void StartDialogue(Dialogue dialogue)
    {
        //Here we need to decide what message we want to send


        //This will control the movement of the dialogue box
        //You need to take pos out, change it and put it back in.
        if(down)
            popup();
        
      



        signupsucc();



        

    }// End of StartDialogue 

    public void popup()
    {
        down = false;

        pos = transform.position;
        Debug.Log("Position: " + pos);
        pos.y += 850;
        transform.position = pos;
    }


    //aka going down
    public void contbutton()
    {
        down = true;

        pos = transform.position;
        Debug.Log("Position: " + pos);
        pos.y += -850;
        transform.position = pos;

    }

    public void changePos()
    {
       
    }


    // Functions that call each change in dialogue to be used as you want.
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
        bodytext.text = ""; //This may branch out into different messages. 
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