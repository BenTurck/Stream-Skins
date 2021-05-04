using UnityEngine;
using UnityEngine.UI;
public class OtherLoginTrueFalse : MonoBehaviour
{
    public GameObject LoginDD;
    public int state = 0;
    //public Text username;
    public Text LoginDDText;
    public Dropdown LoginDDInput;
    private string LoginDDStringInput;
    // Start is called before the first frame update
    void Start()
    {
        LoginDDInput.onValueChanged.AddListener(delegate
        {
            LoginDDValue(LoginDDInput);

        });
    }
    // Update is called once per frame
    void Update()
    {


        if (PlayerPrefs.GetInt("all") == 3) //success
        {
            //username.text = "Username: " + PlayerPrefs.GetString("username");


            LoginDDText.text = PlayerPrefs.GetString("username");

            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login True: " + state);
            LoginDD.SetActive(true);

        }

        if (PlayerPrefs.GetInt("all") == 4)
        {
            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login Fail: " + state);
            LoginDD.SetActive(false);


            //username.text = "Username:";
            LoginDDText.text = PlayerPrefs.GetString("");

        }
        if (PlayerPrefs.GetInt("all") == 0)
        {
            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login False: " + state);
            LoginDD.SetActive(false);


            //username.text = "Username:";
            LoginDDText.text = PlayerPrefs.GetString("");

        }



    }
    public void Signout()
    {
        PlayerPrefs.SetInt("all", 0);
        Debug.Log("Logout True: " + state);
    }


    public void LoginDDValue(Dropdown sender)
    {
        LoginDDStringInput = LoginDDInput.options[LoginDDInput.value].text;

        if (LoginDDStringInput == "SIGN OUT")
        {
            PlayerPrefs.SetInt("all", 0);
        }
    }
}
