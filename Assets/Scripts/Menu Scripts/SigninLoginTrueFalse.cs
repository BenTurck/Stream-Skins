using UnityEngine;
using UnityEngine.UI;
public class SigninLoginTrueFalse : MonoBehaviour
{


    public int state = 0;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {


        if (PlayerPrefs.GetInt("all") == 3) //success
        {

            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login True: " + state);
        }

        if (PlayerPrefs.GetInt("all") == 4)
        {
            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login Fail: " + state);

        }
        if (PlayerPrefs.GetInt("all") == 0)
        {
            state = PlayerPrefs.GetInt("all");
            Debug.Log("Login False: " + state);

        }
    }
}
