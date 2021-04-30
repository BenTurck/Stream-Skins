using UnityEngine;
using UnityEngine.UI;

public class LeagueofLegendsReset : MonoBehaviour
{
	public Dropdown LeagueofLegendsHomeDD;
	public InputField LeagueofLegendsHomeSeasonRecordIF;
	public InputField LeagueofLegendsHomeSeriesScoreIF;
	public InputField LeagueofLegendsHomePlayer1IF;
	public InputField LeagueofLegendsHomePlayer2IF;
	public InputField LeagueofLegendsHomePlayer3IF;
	public InputField LeagueofLegendsHomePlayer4IF;
	public InputField LeagueofLegendsHomePlayer5IF;

	public InputField LeagueofLegendsHomePlayer1StatsIF;
	public InputField LeagueofLegendsHomePlayer2StatsIF;
	public InputField LeagueofLegendsHomePlayer3StatsIF;
	public InputField LeagueofLegendsHomePlayer4StatsIF;
	public InputField LeagueofLegendsHomePlayer5StatsIF;

	public InputField LeagueofLegendsTickerIF;
	public InputField LeagueofLegendsCaster1IF;
	public InputField LeagueofLegendsCaster2IF;

	public Toggle LeagueofLegendsHomeMap1Toggle;
	public Toggle LeagueofLegendsHomeMap2Toggle;
	public Toggle LeagueofLegendsHomeMap3Toggle;
	public Toggle LeagueofLegendsHomeMap4Toggle;
	public Toggle LeagueofLegendsHomeMap5Toggle;

	public Toggle LeagueofLegendsAwayMap1Toggle;
	public Toggle LeagueofLegendsAwayMap2Toggle;
	public Toggle LeagueofLegendsAwayMap3Toggle;
	public Toggle LeagueofLegendsAwayMap4Toggle;
	public Toggle LeagueofLegendsAwayMap5Toggle;

	public Dropdown LeagueofLegendsAwayDD;
	public InputField LeagueofLegendsAwaySeasonRecordIF;
	public InputField LeagueofLegendsAwaySeriesScoreIF;
	public InputField LeagueofLegendsAwayPlayer1IF;
	public InputField LeagueofLegendsAwayPlayer2IF;
	public InputField LeagueofLegendsAwayPlayer3IF;
	public InputField LeagueofLegendsAwayPlayer4IF;
	public InputField LeagueofLegendsAwayPlayer5IF;

	public InputField LeagueofLegendsAwayPlayer1StatsIF;
	public InputField LeagueofLegendsAwayPlayer2StatsIF;
	public InputField LeagueofLegendsAwayPlayer3StatsIF;
	public InputField LeagueofLegendsAwayPlayer4StatsIF;
	public InputField LeagueofLegendsAwayPlayer5StatsIF;

	public void LeagueofLegendsClear()
	{
		LeagueofLegendsHomeDD.value = 0;
		LeagueofLegendsHomeSeasonRecordIF.text = "";
		LeagueofLegendsHomeSeriesScoreIF.text = "0";
		LeagueofLegendsHomePlayer1IF.text = "";
		LeagueofLegendsHomePlayer2IF.text = "";
		LeagueofLegendsHomePlayer3IF.text = "";
		LeagueofLegendsHomePlayer4IF.text = "";
		LeagueofLegendsHomePlayer5IF.text = "";

		LeagueofLegendsHomePlayer1StatsIF.text = "";
		LeagueofLegendsHomePlayer2StatsIF.text = "";
		LeagueofLegendsHomePlayer3StatsIF.text = "";
		LeagueofLegendsHomePlayer4StatsIF.text = "";
		LeagueofLegendsHomePlayer5StatsIF.text = "";

		LeagueofLegendsTickerIF.text = "";
		LeagueofLegendsCaster1IF.text = "";
		LeagueofLegendsCaster2IF.text = "";

		LeagueofLegendsHomeMap1Toggle.isOn = false;
		LeagueofLegendsHomeMap2Toggle.isOn = false;
		LeagueofLegendsHomeMap3Toggle.isOn = false;
		LeagueofLegendsHomeMap4Toggle.isOn = false;
		LeagueofLegendsHomeMap5Toggle.isOn = false;

		LeagueofLegendsAwayMap1Toggle.isOn = false;
		LeagueofLegendsAwayMap2Toggle.isOn = false;
		LeagueofLegendsAwayMap3Toggle.isOn = false;
		LeagueofLegendsAwayMap4Toggle.isOn = false;
		LeagueofLegendsAwayMap5Toggle.isOn = false;

		LeagueofLegendsAwayDD.value = 0;
		LeagueofLegendsAwaySeasonRecordIF.text = "";
		LeagueofLegendsAwaySeriesScoreIF.text = "0";
		LeagueofLegendsAwayPlayer1IF.text = "";
		LeagueofLegendsAwayPlayer2IF.text = "";
		LeagueofLegendsAwayPlayer3IF.text = "";
		LeagueofLegendsAwayPlayer4IF.text = "";
		LeagueofLegendsAwayPlayer5IF.text = "";

		LeagueofLegendsAwayPlayer1StatsIF.text = "";
		LeagueofLegendsAwayPlayer2StatsIF.text = "";
		LeagueofLegendsAwayPlayer3StatsIF.text = "";
		LeagueofLegendsAwayPlayer4StatsIF.text = "";
		LeagueofLegendsAwayPlayer5StatsIF.text = "";
	}
}