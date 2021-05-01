using UnityEngine;

public class LoginTrueFalse : MonoBehaviour
{
    public GameObject MenuStatsButton;
    // Start is called before the first frame update
    void Start()
    {
        //MenuStatsButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuStatsLogin()
    {
        Cognito login = new Cognito();
        if (login.loginSuccessful == true)
        {
            MenuStatsButton.SetActive(true);
        }

        if (login.loginSuccessful == false)
        {
            MenuStatsButton.SetActive(false);
        }

    }

}
