using UnityEngine;
using UnityEngine.UI;

public class CustomReset : MonoBehaviour
{
	public InputField CustomHomeName;
	public InputField CustomHomeSeasonRecordIF;
	public InputField CustomHomeSeriesScoreIF;

	public Toggle CustomHomeActivePlayer1IF;
	public Toggle CustomHomeActivePlayer2IF;
	public Toggle CustomHomeActivePlayer3IF;
	public Toggle CustomHomeActivePlayer4IF;
	public Toggle CustomHomeActivePlayer5IF;
	public Toggle CustomHomeActivePlayer6IF;

	public InputField CustomHomePlayer1IF;
	public InputField CustomHomePlayer2IF;
	public InputField CustomHomePlayer3IF;
	public InputField CustomHomePlayer4IF;
	public InputField CustomHomePlayer5IF;
	public InputField CustomHomePlayer6IF;

	public InputField CustomHomePlayer1StatsIF;
	public InputField CustomHomePlayer2StatsIF;
	public InputField CustomHomePlayer3StatsIF;
	public InputField CustomHomePlayer4StatsIF;
	public InputField CustomHomePlayer5StatsIF;
	public InputField CustomHomePlayer6StatsIF;

	public InputField CustomTickerIF;
	public InputField CustomCaster1IF;
	public InputField CustomCaster2IF;

	public InputField CustomMap1Name;
	public InputField CustomMap2Name;
	public InputField CustomMap3Name;
	public InputField CustomMap4Name;
	public InputField CustomMap5Name;

	public Toggle CustomHomeMap1Toggle;
	public Toggle CustomHomeMap2Toggle;
	public Toggle CustomHomeMap3Toggle;
	public Toggle CustomHomeMap4Toggle;
	public Toggle CustomHomeMap5Toggle;

	public InputField CustomMap1IF;
	public InputField CustomMap2IF;
	public InputField CustomMap3IF;
	public InputField CustomMap4IF;
	public InputField CustomMap5IF;

	public Toggle CustomAwayMap1Toggle;
	public Toggle CustomAwayMap2Toggle;
	public Toggle CustomAwayMap3Toggle;
	public Toggle CustomAwayMap4Toggle;
	public Toggle CustomAwayMap5Toggle;

	public InputField CustomAwayName;
	public InputField CustomAwaySeasonRecordIF;
	public InputField CustomAwaySeriesScoreIF;

	public Toggle CustomAwayActivePlayer1IF;
	public Toggle CustomAwayActivePlayer2IF;
	public Toggle CustomAwayActivePlayer3IF;
	public Toggle CustomAwayActivePlayer4IF;
	public Toggle CustomAwayActivePlayer5IF;
	public Toggle CustomAwayActivePlayer6IF;

	public InputField CustomAwayPlayer1IF;
	public InputField CustomAwayPlayer2IF;
	public InputField CustomAwayPlayer3IF;
	public InputField CustomAwayPlayer4IF;
	public InputField CustomAwayPlayer5IF;
	public InputField CustomAwayPlayer6IF;

	public InputField CustomAwayPlayer1StatsIF;
	public InputField CustomAwayPlayer2StatsIF;
	public InputField CustomAwayPlayer3StatsIF;
	public InputField CustomAwayPlayer4StatsIF;
	public InputField CustomAwayPlayer5StatsIF;
	public InputField CustomAwayPlayer6StatsIF;

	public void CustomClear()
	{
		CustomHomeName.text = "";
		CustomHomeSeasonRecordIF.text = "";
		CustomHomeSeriesScoreIF.text = "0";

		CustomHomeActivePlayer1IF.isOn = false;
		CustomHomeActivePlayer2IF.isOn = false;
		CustomHomeActivePlayer3IF.isOn = false;
		CustomHomeActivePlayer4IF.isOn = false;
		CustomHomeActivePlayer5IF.isOn = false;
		CustomHomeActivePlayer6IF.isOn = false;

		CustomHomePlayer1IF.text = "";
		CustomHomePlayer2IF.text = "";
		CustomHomePlayer3IF.text = "";
		CustomHomePlayer4IF.text = "";
		CustomHomePlayer5IF.text = "";
		CustomHomePlayer6IF.text = "";

		CustomHomePlayer1StatsIF.text = "";
		CustomHomePlayer2StatsIF.text = "";
		CustomHomePlayer3StatsIF.text = "";
		CustomHomePlayer4StatsIF.text = "";
		CustomHomePlayer5StatsIF.text = "";
		CustomHomePlayer6StatsIF.text = "";

		CustomTickerIF.text = "";
		CustomCaster1IF.text = "";
		CustomCaster2IF.text = "";

		CustomMap1Name.text = "";
		CustomMap2Name.text = "";
		CustomMap3Name.text = "";
		CustomMap4Name.text = "";
		CustomMap5Name.text = "";

		CustomHomeMap1Toggle.isOn = false;
		CustomHomeMap2Toggle.isOn = false;
		CustomHomeMap3Toggle.isOn = false;
		CustomHomeMap4Toggle.isOn = false;
		CustomHomeMap5Toggle.isOn = false;

		CustomMap1IF.text = "";
		CustomMap2IF.text = "";
		CustomMap3IF.text = "";
		CustomMap4IF.text = "";
		CustomMap5IF.text = "";

		CustomAwayMap1Toggle.isOn = false;
		CustomAwayMap2Toggle.isOn = false;
		CustomAwayMap3Toggle.isOn = false;
		CustomAwayMap4Toggle.isOn = false;
		CustomAwayMap5Toggle.isOn = false;

		CustomAwayName.text = "";
		CustomAwaySeasonRecordIF.text = "";
		CustomAwaySeriesScoreIF.text = "0";

		CustomAwayActivePlayer1IF.isOn = false;
		CustomAwayActivePlayer2IF.isOn = false;
		CustomAwayActivePlayer3IF.isOn = false;
		CustomAwayActivePlayer4IF.isOn = false;
		CustomAwayActivePlayer5IF.isOn = false;
		CustomAwayActivePlayer6IF.isOn = false;

		CustomAwayPlayer1IF.text = "";
		CustomAwayPlayer2IF.text = "";
		CustomAwayPlayer3IF.text = "";
		CustomAwayPlayer4IF.text = "";
		CustomAwayPlayer5IF.text = "";
		CustomAwayPlayer6IF.text = "";

		CustomAwayPlayer1StatsIF.text = "";
		CustomAwayPlayer2StatsIF.text = "";
		CustomAwayPlayer3StatsIF.text = "";
		CustomAwayPlayer4StatsIF.text = "";
		CustomAwayPlayer5StatsIF.text = "";
		CustomAwayPlayer6StatsIF.text = "";
	}
}