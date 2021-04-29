using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
  
    public void OpenChannel()
    {
        Application.OpenURL("http://streamskinsaws.s3-website.us-east-2.amazonaws.com/");
    }


}
