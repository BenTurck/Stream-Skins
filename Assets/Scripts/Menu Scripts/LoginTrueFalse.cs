using UnityEngine;
using UnityEngine.UI;
public class LoginTrueFalse : MonoBehaviour
{
    public GameObject MenuStatsButton; 
    public int state = 0;
    public Button loginbutt;
    public int test=0;
    public Text username;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        

        if (PlayerPrefs.GetInt("all") == 3) //success
        {
            username.text = "Username: " + PlayerPrefs.GetString("username");

            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login True: " + state);
            MenuStatsButton.SetActive(true);
        }

        if (PlayerPrefs.GetInt("all") == 4)
        {
            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login Fail: " + state);
            MenuStatsButton.SetActive(false);

            username.text = "Username:";

        }
        if (PlayerPrefs.GetInt("all") == 0)
        {
            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login False: " + state);
            MenuStatsButton.SetActive(false);

            username.text = "Username:";
        }



    }
    public void Signout()
    {
        PlayerPrefs.SetInt("all" ,0);
        Debug.Log("Logout True: " + state);
    }
}
