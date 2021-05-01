using UnityEngine;
using UnityEngine.UI;
public class LoginTrueFalse : MonoBehaviour
{
    public GameObject MenuStatsButton;
    public bool test; //possible deletion 
    public int state = 0;
    public Button loginbutt;
    // Start is called before the first frame update
    void Start()
    {
        //MenuStatsButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        state = PlayerPrefs.GetInt("all");
        Debug.Log("loginTruaFa1se boolean --> " + state);
    }
    /*
    public void setltfb(bool setter)
    {
        test = setter;
        Debug.Log("loginTrueFalse boolean --> " + test);
        return;
    }*/

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
