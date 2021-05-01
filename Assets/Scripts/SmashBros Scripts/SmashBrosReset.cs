using UnityEngine;
using UnityEngine.UI;

public class SmashBrosReset : MonoBehaviour
{
	public Dropdown SmashBrosHomeDD;
	public InputField SmashBrosHomeSeasonRecordIF;
	public InputField SmashBrosHomeSeriesScoreIF;
	public InputField SmashBrosHomeStocksIF;

	public Toggle SmashBrosHomeActivePlayer1IF;
	public Toggle SmashBrosHomeActivePlayer2IF;
	public Toggle SmashBrosHomeActivePlayer3IF;

	public InputField SmashBrosHomePlayer1IF;
	public InputField SmashBrosHomePlayer2IF;
	public InputField SmashBrosHomePlayer3IF;

	public InputField SmashBrosHomePlayer1StatsIF;
	public InputField SmashBrosHomePlayer2StatsIF;
	public InputField SmashBrosHomePlayer3StatsIF;

	public InputField SmashBrosTickerIF;
	public InputField SmashBrosCaster1IF;
	public InputField SmashBrosCaster2IF;

	public Toggle SmashBrosHomeMap1Toggle;
	public Toggle SmashBrosHomeMap2Toggle;
	public Toggle SmashBrosHomeMap3Toggle;

	public InputField SmashBrosMap1IF;
	public InputField SmashBrosMap2IF;
	public InputField SmashBrosMap3IF;

	public Toggle SmashBrosAwayMap1Toggle;
	public Toggle SmashBrosAwayMap2Toggle;
	public Toggle SmashBrosAwayMap3Toggle;

	public Dropdown SmashBrosAwayDD;
	public InputField SmashBrosAwaySeasonRecordIF;
	public InputField SmashBrosAwaySeriesScoreIF;
	public InputField SmashBrosAwayStocksIF;

	public Toggle SmashBrosAwayActivePlayer1IF;
	public Toggle SmashBrosAwayActivePlayer2IF;
	public Toggle SmashBrosAwayActivePlayer3IF;

	public InputField SmashBrosAwayPlayer1IF;
	public InputField SmashBrosAwayPlayer2IF;
	public InputField SmashBrosAwayPlayer3IF;

	public InputField SmashBrosAwayPlayer1StatsIF;
	public InputField SmashBrosAwayPlayer2StatsIF;
	public InputField SmashBrosAwayPlayer3StatsIF;


	public void SmashBrosClear()
	{
		SmashBrosHomeDD.value = 0;
		SmashBrosHomeSeasonRecordIF.text = "";
		SmashBrosHomeSeriesScoreIF.text = "0";
		SmashBrosHomeStocksIF.text = "9";

		SmashBrosHomeActivePlayer1IF.isOn = false;
		SmashBrosHomeActivePlayer2IF.isOn = false;
		SmashBrosHomeActivePlayer3IF.isOn = false;

		SmashBrosHomePlayer1IF.text = "";
		SmashBrosHomePlayer2IF.text = "";
		SmashBrosHomePlayer3IF.text = "";

		SmashBrosHomePlayer1StatsIF.text = "";
		SmashBrosHomePlayer2StatsIF.text = "";
		SmashBrosHomePlayer3StatsIF.text = "";

		SmashBrosTickerIF.text = "";
		SmashBrosCaster1IF.text = "";
		SmashBrosCaster2IF.text = "";

		SmashBrosHomeMap1Toggle.isOn = false;
		SmashBrosHomeMap2Toggle.isOn = false;
		SmashBrosHomeMap3Toggle.isOn = false;

		SmashBrosMap1IF.text = "";
		SmashBrosMap2IF.text = "";
		SmashBrosMap3IF.text = "";

		SmashBrosAwayMap1Toggle.isOn = false;
		SmashBrosAwayMap2Toggle.isOn = false;
		SmashBrosAwayMap3Toggle.isOn = false;

		SmashBrosAwayDD.value = 0;
		SmashBrosAwaySeasonRecordIF.text = "";
		SmashBrosAwaySeriesScoreIF.text = "0";
		SmashBrosAwayStocksIF.text = "9";

		SmashBrosAwayActivePlayer1IF.isOn = false;
		SmashBrosAwayActivePlayer2IF.isOn = false;
		SmashBrosAwayActivePlayer3IF.isOn = false;

		SmashBrosAwayPlayer1IF.text = "";
		SmashBrosAwayPlayer2IF.text = "";
		SmashBrosAwayPlayer3IF.text = "";

		SmashBrosAwayPlayer1StatsIF.text = "";
		SmashBrosAwayPlayer2StatsIF.text = "";
		SmashBrosAwayPlayer3StatsIF.text = "";
	}
}