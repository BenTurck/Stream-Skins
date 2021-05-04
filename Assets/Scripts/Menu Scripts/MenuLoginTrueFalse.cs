using UnityEngine;
using UnityEngine.UI;
public class MenuLoginTrueFalse : MonoBehaviour
{
    public GameObject MenuStatsButton;
    public GameObject MenuSignoutButton;
    public GameObject MenuSigninButton;
    public GameObject LoginDD;
    public int state = 0;
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
            LoginDDText.text = PlayerPrefs.GetString("username");

            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login True: " + state);
            MenuStatsButton.SetActive(true);
            LoginDD.SetActive(true);
            MenuSigninButton.SetActive(false);
            MenuSignoutButton.SetActive(true);
        }

        if (PlayerPrefs.GetInt("all") == 4)
        {
            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login Fail: " + state);
            MenuStatsButton.SetActive(false);
            LoginDD.SetActive(false);
            MenuSigninButton.SetActive(true);
            MenuSignoutButton.SetActive(false);

            LoginDDText.text = PlayerPrefs.GetString("");

        }
        if (PlayerPrefs.GetInt("all") == 0)
        {
            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login False: " + state);
            MenuStatsButton.SetActive(false);
            LoginDD.SetActive(false);
            MenuSigninButton.SetActive(true);
            MenuSignoutButton.SetActive(false);

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
