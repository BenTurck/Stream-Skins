using UnityEngine;
using UnityEngine.UI;

public class OverwatchReset : MonoBehaviour
{
	public Dropdown OverwatchHomeDD;
	public InputField OverwatchHomeSeasonRecordIF;
	public InputField OverwatchHomeSeriesScoreIF;
	public InputField OverwatchHomePlayer1IF;
	public InputField OverwatchHomePlayer2IF;
	public InputField OverwatchHomePlayer3IF;
	public InputField OverwatchHomePlayer4IF;
	public InputField OverwatchHomePlayer5IF;
	public InputField OverwatchHomePlayer6IF;

	public InputField OverwatchHomePlayer1StatsIF;
	public InputField OverwatchHomePlayer2StatsIF;
	public InputField OverwatchHomePlayer3StatsIF;
	public InputField OverwatchHomePlayer4StatsIF;
	public InputField OverwatchHomePlayer5StatsIF;
	public InputField OverwatchHomePlayer6StatsIF;

	public InputField OverwatchTickerIF;
	public InputField OverwatchCaster1IF;
	public InputField OverwatchCaster2IF;

	public Dropdown OverwatchMap1DD;
	public Dropdown OverwatchMap2DD;
	public Dropdown OverwatchMap3DD;
	public Dropdown OverwatchMap4DD;
	public Dropdown OverwatchMap5DD;

	public Toggle OverwatchHomeMap1Toggle;
	public Toggle OverwatchHomeMap2Toggle;
	public Toggle OverwatchHomeMap3Toggle;
	public Toggle OverwatchHomeMap4Toggle;
	public Toggle OverwatchHomeMap5Toggle;

	public InputField OverwatchMap1IF;
	public InputField OverwatchMap2IF;
	public InputField OverwatchMap3IF;
	public InputField OverwatchMap4IF;
	public InputField OverwatchMap5IF;

	public Toggle OverwatchAwayMap1Toggle;
	public Toggle OverwatchAwayMap2Toggle;
	public Toggle OverwatchAwayMap3Toggle;
	public Toggle OverwatchAwayMap4Toggle;
	public Toggle OverwatchAwayMap5Toggle;

	public Dropdown OverwatchAwayDD;
	public InputField OverwatchAwaySeasonRecordIF;
	public InputField OverwatchAwaySeriesScoreIF;
	public InputField OverwatchAwayPlayer1IF;
	public InputField OverwatchAwayPlayer2IF;
	public InputField OverwatchAwayPlayer3IF;
	public InputField OverwatchAwayPlayer4IF;
	public InputField OverwatchAwayPlayer5IF;
	public InputField OverwatchAwayPlayer6IF;

	public InputField OverwatchAwayPlayer1StatsIF;
	public InputField OverwatchAwayPlayer2StatsIF;
	public InputField OverwatchAwayPlayer3StatsIF;
	public InputField OverwatchAwayPlayer4StatsIF;
	public InputField OverwatchAwayPlayer5StatsIF;
	public InputField OverwatchAwayPlayer6StatsIF;

	public void OverwatchClear()
	{
		OverwatchHomeDD.value = 0;
		OverwatchHomeSeasonRecordIF.text = "";
		OverwatchHomeSeriesScoreIF.text = "0";
		OverwatchHomePlayer1IF.text = "";
		OverwatchHomePlayer2IF.text = "";
		OverwatchHomePlayer3IF.text = "";
		OverwatchHomePlayer4IF.text = "";
		OverwatchHomePlayer5IF.text = "";
		OverwatchHomePlayer6IF.text = "";

		OverwatchHomePlayer1StatsIF.text = "";
		OverwatchHomePlayer2StatsIF.text = "";
		OverwatchHomePlayer3StatsIF.text = "";
		OverwatchHomePlayer4StatsIF.text = "";
		OverwatchHomePlayer5StatsIF.text = "";
		OverwatchHomePlayer6StatsIF.text = "";

		OverwatchTickerIF.text = "";
		OverwatchCaster1IF.text = "";
		OverwatchCaster2IF.text = "";

		OverwatchMap1DD.value = 0;
		OverwatchMap2DD.value = 0;
		OverwatchMap3DD.value = 0;
		OverwatchMap4DD.value = 0;
		OverwatchMap5DD.value = 0;

		OverwatchHomeMap1Toggle.isOn = false;
		OverwatchHomeMap2Toggle.isOn = false;
		OverwatchHomeMap3Toggle.isOn = false;
		OverwatchHomeMap4Toggle.isOn = false;
		OverwatchHomeMap5Toggle.isOn = false;

		OverwatchMap1IF.text = "";
		OverwatchMap2IF.text = "";
		OverwatchMap3IF.text = "";
		OverwatchMap4IF.text = "";
		OverwatchMap5IF.text = "";

		OverwatchAwayMap1Toggle.isOn = false;
		OverwatchAwayMap2Toggle.isOn = false;
		OverwatchAwayMap3Toggle.isOn = false;
		OverwatchAwayMap4Toggle.isOn = false;
		OverwatchAwayMap5Toggle.isOn = false;

		OverwatchAwayDD.value = 0;
		OverwatchAwaySeasonRecordIF.text = "";
		OverwatchAwaySeriesScoreIF.text = "0";
		OverwatchAwayPlayer1IF.text = "";
		OverwatchAwayPlayer2IF.text = "";
		OverwatchAwayPlayer3IF.text = "";
		OverwatchAwayPlayer4IF.text = "";
		OverwatchAwayPlayer5IF.text = "";
		OverwatchAwayPlayer6IF.text = "";

		OverwatchAwayPlayer1StatsIF.text = "";
		OverwatchAwayPlayer2StatsIF.text = "";
		OverwatchAwayPlayer3StatsIF.text = "";
		OverwatchAwayPlayer4StatsIF.text = "";
		OverwatchAwayPlayer5StatsIF.text = "";
		OverwatchAwayPlayer6StatsIF.text = "";
	}
}