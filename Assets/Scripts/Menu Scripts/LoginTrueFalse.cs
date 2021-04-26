using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginTrueFalse : MonoBehaviour
{
    public GameObject MenuStatsButton;
    // Start is called before the first frame update
    void Start()
    {
        MenuStatsButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuStatsLogin()
    {
        Cognito obj = new Cognito();
        if (obj.loginScene == true)
        {
            MenuStatsButton.SetActive(true);
        }

        if (obj.loginScene == false)
        {
            MenuStatsButton.SetActive(false);
        }

    }

}
