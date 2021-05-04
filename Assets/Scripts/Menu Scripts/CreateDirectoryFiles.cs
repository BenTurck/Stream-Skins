using UnityEngine;
using System.IO;

public class CreateDirectoryFiles
{
    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Start()
    {        
        Directory.CreateDirectory("Assets/TeamLogos/");
        Directory.CreateDirectory("Assets/GameMaps/");
        Directory.CreateDirectory("Assets/Overlays/");
        Directory.CreateDirectory("Assets/Games/Valorant/");
        Directory.CreateDirectory("Assets/Games/Overwatch/");
        Directory.CreateDirectory("Assets/Games/Smash Bros/");
        Directory.CreateDirectory("Assets/Games/League of Legends/");
        Directory.CreateDirectory("Assets/Games/Custom/");



        File.Create("Assets/Games/Valorant/Ticker.txt");
        File.Create("Assets/Games/Valorant/Caster1.txt");
        File.Create("Assets/Games/Valorant/Caster2.txt");

        File.Create("Assets/Games/Valorant/Map1 Name.txt");
        File.Create("Assets/Games/Valorant/Map2 Name.txt");
        File.Create("Assets/Games/Valorant/Map3 Name.txt");
        File.Create("Assets/Games/Valorant/Map4 Name.txt");
        File.Create("Assets/Games/Valorant/Map5 Name.txt");

        File.Create("Assets/Games/Valorant/Map 1.png");
        File.Create("Assets/Games/Valorant/Map 2.png");
        File.Create("Assets/Games/Valorant/Map 3.png");
        File.Create("Assets/Games/Valorant/Map 4.png");
        File.Create("Assets/Games/Valorant/Map 5.png");

        File.Create("Assets/Games/Valorant/Game1 Score.txt");
        File.Create("Assets/Games/Valorant/Game2 Score.txt");
        File.Create("Assets/Games/Valorant/Game3 Score.txt");
        File.Create("Assets/Games/Valorant/Game4 Score.txt");
        File.Create("Assets/Games/Valorant/Game5 Score.txt");

        File.Create("Assets/Games/Valorant/Map 1 Played.png");
        File.Create("Assets/Games/Valorant/Map 2 Played.png");
        File.Create("Assets/Games/Valorant/Map 3 Played.png");
        File.Create("Assets/Games/Valorant/Map 4 Played.png");
        File.Create("Assets/Games/Valorant/Map 5 Played.png");

        File.Create("Assets/Games/Valorant/Game1 Winner.txt");
        File.Create("Assets/Games/Valorant/Game2 Winner.txt");
        File.Create("Assets/Games/Valorant/Game3 Winner.txt");
        File.Create("Assets/Games/Valorant/Game4 Winner.txt");
        File.Create("Assets/Games/Valorant/Game5 Winner.txt");

        File.Create("Assets/Games/Valorant/Map 1 Winner.png");
        File.Create("Assets/Games/Valorant/Map 2 Winner.png");
        File.Create("Assets/Games/Valorant/Map 3 Winner.png");
        File.Create("Assets/Games/Valorant/Map 4 Winner.png");
        File.Create("Assets/Games/Valorant/Map 5 Winner.png");

        File.Create("Assets/Games/Valorant/Home Logo.png");

        File.Create("Assets/Games/Valorant/Home Team Name.txt");
        File.Create("Assets/Games/Valorant/Home Team Season Record.txt");
        File.Create("Assets/Games/Valorant/Home Team Series Score.txt");

        File.Create("Assets/Games/Valorant/Home Team Player1.txt");
        File.Create("Assets/Games/Valorant/Home Team Player2.txt");
        File.Create("Assets/Games/Valorant/Home Team Player3.txt");
        File.Create("Assets/Games/Valorant/Home Team Player4.txt");
        File.Create("Assets/Games/Valorant/Home Team Player5.txt");

        File.Create("Assets/Games/Valorant/Home Team Player1 Stats.txt");
        File.Create("Assets/Games/Valorant/Home Team Player2 Stats.txt");
        File.Create("Assets/Games/Valorant/Home Team Player3 Stats.txt");
        File.Create("Assets/Games/Valorant/Home Team Player4 Stats.txt");
        File.Create("Assets/Games/Valorant/Home Team Player5 Stats.txt");

        File.Create("Assets/Games/Valorant/Away Logo.png");

        File.Create("Assets/Games/Valorant/Away Team Name.txt");
        File.Create("Assets/Games/Valorant/Away Team Season Record.txt");
        File.Create("Assets/Games/Valorant/Away Team Series Score.txt");

        File.Create("Assets/Games/Valorant/Away Team Player1.txt");
        File.Create("Assets/Games/Valorant/Away Team Player2.txt");
        File.Create("Assets/Games/Valorant/Away Team Player3.txt");
        File.Create("Assets/Games/Valorant/Away Team Player4.txt");
        File.Create("Assets/Games/Valorant/Away Team Player5.txt");

        File.Create("Assets/Games/Valorant/Away Team Player1 Stats.txt");
        File.Create("Assets/Games/Valorant/Away Team Player2 Stats.txt");
        File.Create("Assets/Games/Valorant/Away Team Player3 Stats.txt");
        File.Create("Assets/Games/Valorant/Away Team Player4 Stats.txt");
        File.Create("Assets/Games/Valorant/Away Team Player5 Stats.txt");

        

        File.Create("Assets/Games/Overwatch/Ticker.txt");
        File.Create("Assets/Games/Overwatch/Caster1.txt");
        File.Create("Assets/Games/Overwatch/Caster2.txt");

        File.Create("Assets/Games/Overwatch/Map1 Name.txt");
        File.Create("Assets/Games/Overwatch/Map2 Name.txt");
        File.Create("Assets/Games/Overwatch/Map3 Name.txt");
        File.Create("Assets/Games/Overwatch/Map4 Name.txt");
        File.Create("Assets/Games/Overwatch/Map5 Name.txt");

        File.Create("Assets/Games/Overwatch/Map 1.png");
        File.Create("Assets/Games/Overwatch/Map 2.png");
        File.Create("Assets/Games/Overwatch/Map 3.png");
        File.Create("Assets/Games/Overwatch/Map 4.png");
        File.Create("Assets/Games/Overwatch/Map 5.png");

        File.Create("Assets/Games/Overwatch/Game1 Score.txt");
        File.Create("Assets/Games/Overwatch/Game2 Score.txt");
        File.Create("Assets/Games/Overwatch/Game3 Score.txt");
        File.Create("Assets/Games/Overwatch/Game4 Score.txt");
        File.Create("Assets/Games/Overwatch/Game5 Score.txt");

        File.Create("Assets/Games/Overwatch/Map 1 Played.png");
        File.Create("Assets/Games/Overwatch/Map 2 Played.png");
        File.Create("Assets/Games/Overwatch/Map 3 Played.png");
        File.Create("Assets/Games/Overwatch/Map 4 Played.png");
        File.Create("Assets/Games/Overwatch/Map 5 Played.png");

        File.Create("Assets/Games/Overwatch/Game1 Winner.txt");
        File.Create("Assets/Games/Overwatch/Game2 Winner.txt");
        File.Create("Assets/Games/Overwatch/Game3 Winner.txt");
        File.Create("Assets/Games/Overwatch/Game4 Winner.txt");
        File.Create("Assets/Games/Overwatch/Game5 Winner.txt");

        File.Create("Assets/Games/Overwatch/Map 1 Winner.png");
        File.Create("Assets/Games/Overwatch/Map 2 Winner.png");
        File.Create("Assets/Games/Overwatch/Map 3 Winner.png");
        File.Create("Assets/Games/Overwatch/Map 4 Winner.png");
        File.Create("Assets/Games/Overwatch/Map 5 Winner.png");

        File.Create("Assets/Games/Overwatch/Home Logo.png");

        File.Create("Assets/Games/Overwatch/Home Team Name.txt");
        File.Create("Assets/Games/Overwatch/Home Team Season Record.txt");
        File.Create("Assets/Games/Overwatch/Home Team Series Score.txt");

        File.Create("Assets/Games/Overwatch/Home Team Player1.txt");
        File.Create("Assets/Games/Overwatch/Home Team Player2.txt");
        File.Create("Assets/Games/Overwatch/Home Team Player3.txt");
        File.Create("Assets/Games/Overwatch/Home Team Player4.txt");
        File.Create("Assets/Games/Overwatch/Home Team Player5.txt");
        File.Create("Assets/Games/Overwatch/Home Team Player6.txt");

        File.Create("Assets/Games/Overwatch/Home Team Player1 Stats.txt");
        File.Create("Assets/Games/Overwatch/Home Team Player2 Stats.txt");
        File.Create("Assets/Games/Overwatch/Home Team Player3 Stats.txt");
        File.Create("Assets/Games/Overwatch/Home Team Player4 Stats.txt");
        File.Create("Assets/Games/Overwatch/Home Team Player5 Stats.txt");
        File.Create("Assets/Games/Overwatch/Home Team Player6 Stats.txt");

        File.Create("Assets/Games/Overwatch/Away Logo.png");

        File.Create("Assets/Games/Overwatch/Away Team Name.txt");
        File.Create("Assets/Games/Overwatch/Away Team Season Record.txt");
        File.Create("Assets/Games/Overwatch/Away Team Series Score.txt");

        File.Create("Assets/Games/Overwatch/Away Team Player1.txt");
        File.Create("Assets/Games/Overwatch/Away Team Player2.txt");
        File.Create("Assets/Games/Overwatch/Away Team Player3.txt");
        File.Create("Assets/Games/Overwatch/Away Team Player4.txt");
        File.Create("Assets/Games/Overwatch/Away Team Player5.txt");
        File.Create("Assets/Games/Overwatch/Away Team Player6.txt");

        File.Create("Assets/Games/Overwatch/Away Team Player1 Stats.txt");
        File.Create("Assets/Games/Overwatch/Away Team Player2 Stats.txt");
        File.Create("Assets/Games/Overwatch/Away Team Player3 Stats.txt");
        File.Create("Assets/Games/Overwatch/Away Team Player4 Stats.txt");
        File.Create("Assets/Games/Overwatch/Away Team Player5 Stats.txt");
        File.Create("Assets/Games/Overwatch/Away Team Player6 Stats.txt");

        

        File.Create("Assets/Games/Smash Bros/Ticker.txt");
        File.Create("Assets/Games/Smash Bros/Caster1.txt");
        File.Create("Assets/Games/Smash Bros/Caster2.txt");

        File.Create("Assets/Games/Smash Bros/Game1 Score.txt");
        File.Create("Assets/Games/Smash Bros/Game2 Score.txt");
        File.Create("Assets/Games/Smash Bros/Game3 Score.txt");

        File.Create("Assets/Games/Smash Bros/Map 1 Played.png");
        File.Create("Assets/Games/Smash Bros/Map 2 Played.png");
        File.Create("Assets/Games/Smash Bros/Map 3 Played.png");

        File.Create("Assets/Games/Smash Bros/Game1 Winner.txt");
        File.Create("Assets/Games/Smash Bros/Game2 Winner.txt");
        File.Create("Assets/Games/Smash Bros/Game3 Winner.txt");

        File.Create("Assets/Games/Smash Bros/Map 1 Winner.png");
        File.Create("Assets/Games/Smash Bros/Map 2 Winner.png");
        File.Create("Assets/Games/Smash Bros/Map 3 Winner.png");

        File.Create("Assets/Games/Smash Bros/Home Logo.png");

        File.Create("Assets/Games/Smash Bros/Home Team Name.txt");
        File.Create("Assets/Games/Smash Bros/Home Team Season Record.txt");
        File.Create("Assets/Games/Smash Bros/Home Team Series Score.txt");
        File.Create("Assets/Games/Smash Bros/Home Team Stocks.txt");

        File.Create("Assets/Games/Smash Bros/Home Team Player1.txt");
        File.Create("Assets/Games/Smash Bros/Home Team Player2.txt");
        File.Create("Assets/Games/Smash Bros/Home Team Player3.txt");
        File.Create("Assets/Games/Smash Bros/Home Team Active Player.txt");

        File.Create("Assets/Games/Smash Bros/Home Team Player1 Stats.txt");
        File.Create("Assets/Games/Smash Bros/Home Team Player2 Stats.txt");
        File.Create("Assets/Games/Smash Bros/Home Team Player3 Stats.txt");

        File.Create("Assets/Games/Smash Bros/Away Logo.png");

        File.Create("Assets/Games/Smash Bros/Away Team Name.txt");
        File.Create("Assets/Games/Smash Bros/Away Team Season Record.txt");
        File.Create("Assets/Games/Smash Bros/Away Team Series Score.txt");
        File.Create("Assets/Games/Smash Bros/Away Team Stocks.txt");

        File.Create("Assets/Games/Smash Bros/Away Team Player1.txt");
        File.Create("Assets/Games/Smash Bros/Away Team Player2.txt");
        File.Create("Assets/Games/Smash Bros/Away Team Player3.txt");
        File.Create("Assets/Games/Smash Bros/Away Team Active Player.txt");

        File.Create("Assets/Games/Smash Bros/Away Team Player1 Stats.txt");
        File.Create("Assets/Games/Smash Bros/Away Team Player2 Stats.txt");
        File.Create("Assets/Games/Smash Bros/Away Team Player3 Stats.txt");



        File.Create("Assets/Games/League of Legends/Ticker.txt");
        File.Create("Assets/Games/League of Legends/Caster1.txt");
        File.Create("Assets/Games/League of Legends/Caster2.txt");

        File.Create("Assets/Games/League of Legends/Game1 Winner.txt");
        File.Create("Assets/Games/League of Legends/Game2 Winner.txt");
        File.Create("Assets/Games/League of Legends/Game3 Winner.txt");

        File.Create("Assets/Games/League of Legends/Map 1 Winner.png");
        File.Create("Assets/Games/League of Legends/Map 2 Winner.png");
        File.Create("Assets/Games/League of Legends/Map 3 Winner.png");

        File.Create("Assets/Games/League of Legends/Map 1 Played.png");
        File.Create("Assets/Games/League of Legends/Map 2 Played.png");
        File.Create("Assets/Games/League of Legends/Map 3 Played.png");

        File.Create("Assets/Games/League of Legends/Home Logo.png");

        File.Create("Assets/Games/League of Legends/Home Team Name.txt");
        File.Create("Assets/Games/League of Legends/Home Team Season Record.txt");
        File.Create("Assets/Games/League of Legends/Home Team Series Score.txt");

        File.Create("Assets/Games/League of Legends/Home Team Player1.txt");
        File.Create("Assets/Games/League of Legends/Home Team Player2.txt");
        File.Create("Assets/Games/League of Legends/Home Team Player3.txt");
        File.Create("Assets/Games/League of Legends/Home Team Player4.txt");
        File.Create("Assets/Games/League of Legends/Home Team Player5.txt");

        File.Create("Assets/Games/League of Legends/Home Team Player1 Stats.txt");
        File.Create("Assets/Games/League of Legends/Home Team Player2 Stats.txt");
        File.Create("Assets/Games/League of Legends/Home Team Player3 Stats.txt");
        File.Create("Assets/Games/League of Legends/Home Team Player4 Stats.txt");
        File.Create("Assets/Games/League of Legends/Home Team Player5 Stats.txt");

        File.Create("Assets/Games/League of Legends/Away Logo.png");

        File.Create("Assets/Games/League of Legends/Away Team Name.txt");
        File.Create("Assets/Games/League of Legends/Away Team Season Record.txt");
        File.Create("Assets/Games/League of Legends/Away Team Series Score.txt");

        File.Create("Assets/Games/League of Legends/Away Team Player1.txt");
        File.Create("Assets/Games/League of Legends/Away Team Player2.txt");
        File.Create("Assets/Games/League of Legends/Away Team Player3.txt");
        File.Create("Assets/Games/League of Legends/Away Team Player4.txt");
        File.Create("Assets/Games/League of Legends/Away Team Player5.txt");

        File.Create("Assets/Games/League of Legends/Away Team Player1 Stats.txt");
        File.Create("Assets/Games/League of Legends/Away Team Player2 Stats.txt");
        File.Create("Assets/Games/League of Legends/Away Team Player3 Stats.txt");
        File.Create("Assets/Games/League of Legends/Away Team Player4 Stats.txt");
        File.Create("Assets/Games/League of Legends/Away Team Player5 Stats.txt");



        File.Create("Assets/Games/Custom/Ticker.txt");
        File.Create("Assets/Games/Custom/Caster1.txt");
        File.Create("Assets/Games/Custom/Caster2.txt");

        File.Create("Assets/Games/Custom/Game1 Score.txt");
        File.Create("Assets/Games/Custom/Game2 Score.txt");
        File.Create("Assets/Games/Custom/Game3 Score.txt");
        File.Create("Assets/Games/Custom/Game4 Score.txt");
        File.Create("Assets/Games/Custom/Game5 Score.txt");

        File.Create("Assets/Games/Custom/Map 1 Played.png");
        File.Create("Assets/Games/Custom/Map 2 Played.png");
        File.Create("Assets/Games/Custom/Map 3 Played.png");
        File.Create("Assets/Games/Custom/Map 4 Played.png");
        File.Create("Assets/Games/Custom/Map 5 Played.png");

        File.Create("Assets/Games/Custom/Map 1 Name.txt");
        File.Create("Assets/Games/Custom/Map 2 Name.txt");
        File.Create("Assets/Games/Custom/Map 3 Name.txt");
        File.Create("Assets/Games/Custom/Map 4 Name.txt");
        File.Create("Assets/Games/Custom/Map 5 Name.txt");

        File.Create("Assets/Games/Custom/Map 1.png");
        File.Create("Assets/Games/Custom/Map 2.png");
        File.Create("Assets/Games/Custom/Map 3.png");
        File.Create("Assets/Games/Custom/Map 4.png");
        File.Create("Assets/Games/Custom/Map 5.png");

        File.Create("Assets/Games/Custom/Game1 Winner.txt");
        File.Create("Assets/Games/Custom/Game2 Winner.txt");
        File.Create("Assets/Games/Custom/Game3 Winner.txt");
        File.Create("Assets/Games/Custom/Game4 Winner.txt");
        File.Create("Assets/Games/Custom/Game5 Winner.txt");

        File.Create("Assets/Games/Custom/Map 1 Winner.png");
        File.Create("Assets/Games/Custom/Map 2 Winner.png");
        File.Create("Assets/Games/Custom/Map 3 Winner.png");
        File.Create("Assets/Games/Custom/Map 4 Winner.png");
        File.Create("Assets/Games/Custom/Map 5 Winner.png");

        File.Create("Assets/Games/Custom/Home Logo.png");

        File.Create("Assets/Games/Custom/Home Team Name.txt");
        File.Create("Assets/Games/Custom/Home Team Season Record.txt");
        File.Create("Assets/Games/Custom/Home Team Series Score.txt");

        File.Create("Assets/Games/Custom/Home Team Active Player.txt");

        File.Create("Assets/Games/Custom/Home Team Player1.txt");
        File.Create("Assets/Games/Custom/Home Team Player2.txt");
        File.Create("Assets/Games/Custom/Home Team Player3.txt");
        File.Create("Assets/Games/Custom/Home Team Player4.txt");
        File.Create("Assets/Games/Custom/Home Team Player5.txt");
        File.Create("Assets/Games/Custom/Home Team Player6.txt");

        File.Create("Assets/Games/Custom/Home Team Player1 Stats.txt");
        File.Create("Assets/Games/Custom/Home Team Player2 Stats.txt");
        File.Create("Assets/Games/Custom/Home Team Player3 Stats.txt");
        File.Create("Assets/Games/Custom/Home Team Player4 Stats.txt");
        File.Create("Assets/Games/Custom/Home Team Player5 Stats.txt");
        File.Create("Assets/Games/Custom/Home Team Player6 Stats.txt");

        File.Create("Assets/Games/Custom/Away Logo.png");

        File.Create("Assets/Games/Custom/Away Team Name.txt");
        File.Create("Assets/Games/Custom/Away Team Season Record.txt");
        File.Create("Assets/Games/Custom/Away Team Series Score.txt");

        File.Create("Assets/Games/Custom/Away Team Active Player.txt");

        File.Create("Assets/Games/Custom/Away Team Player1.txt");
        File.Create("Assets/Games/Custom/Away Team Player2.txt");
        File.Create("Assets/Games/Custom/Away Team Player3.txt");
        File.Create("Assets/Games/Custom/Away Team Player4.txt");
        File.Create("Assets/Games/Custom/Away Team Player5.txt");
        File.Create("Assets/Games/Custom/Away Team Player6.txt");

        File.Create("Assets/Games/Custom/Away Team Player1 Stats.txt");
        File.Create("Assets/Games/Custom/Away Team Player2 Stats.txt");
        File.Create("Assets/Games/Custom/Away Team Player3 Stats.txt");
        File.Create("Assets/Games/Custom/Away Team Player4 Stats.txt");
        File.Create("Assets/Games/Custom/Away Team Player5 Stats.txt");
        File.Create("Assets/Games/Custom/Away Team Player6 Stats.txt");

        PlayerPrefs.SetInt("all", 0);
        Debug.Log("Logout True: ");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
