using UnityEngine;
using UnityEngine.UI;

public class StatsShowHide : MonoBehaviour
{

    public GameObject StatsValorantObjects;
    public GameObject StatsOverwatchObjects;
    public GameObject StatsSmashBrosObjects;
    public GameObject StatsLeagueofLegendsObjects;
    //public GameObject StatsCustomObjects;

    public Dropdown StatsGameDDInput;
    private string StatsGameDDStringInput;

    // Start is called before the first frame update
    void Start()
    {
        StatsGameDDInput.onValueChanged.AddListener(delegate
        {
            StatsGameDDValue(StatsGameDDInput);

        });
        StatsValorantObjects.SetActive(false);
        StatsOverwatchObjects.SetActive(false);
        StatsSmashBrosObjects.SetActive(false);
        StatsLeagueofLegendsObjects.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StatsGameDDValue(Dropdown sender)
    {
        StatsGameDDStringInput = StatsGameDDInput.options[StatsGameDDInput.value].text;

        if (StatsGameDDStringInput == "SELECT GAME")
        {
            Debug.Log("NONE");
            StatsValorantObjects.SetActive(false);
            StatsOverwatchObjects.SetActive(false);
            StatsSmashBrosObjects.SetActive(false);
            StatsLeagueofLegendsObjects.SetActive(false);
        }

        if (StatsGameDDStringInput == "VALORANT")
        {
            Debug.Log("Game: Valorant");
            StatsValorantObjects.SetActive(true);
            StatsOverwatchObjects.SetActive(false);
            StatsSmashBrosObjects.SetActive(false);
            StatsLeagueofLegendsObjects.SetActive(false);
        }

        if (StatsGameDDStringInput == "OVERWATCH")
        {
            Debug.Log("Game: OVERWATCH");
            StatsValorantObjects.SetActive(false);
            StatsOverwatchObjects.SetActive(true);
            StatsSmashBrosObjects.SetActive(false);
            StatsLeagueofLegendsObjects.SetActive(false);
        }

        if (StatsGameDDStringInput == "SMASH BROS")
        {
            Debug.Log("Game: SMASH BROS");
            StatsValorantObjects.SetActive(false);
            StatsOverwatchObjects.SetActive(false);
            StatsSmashBrosObjects.SetActive(true);
            StatsLeagueofLegendsObjects.SetActive(false);
        }

        if (StatsGameDDStringInput == "LEAGUE OF LEGENDS")
        {
            Debug.Log("Game: LEAGUE OF LEGENDS");
            StatsValorantObjects.SetActive(false);
            StatsOverwatchObjects.SetActive(false);
            StatsSmashBrosObjects.SetActive(false);
            StatsLeagueofLegendsObjects.SetActive(true);
        }
    }
}
