using UnityEngine;
using UnityEngine.UI;

public class ValorantReset : MonoBehaviour
{
	public Dropdown ValorantHomeDD;
	public InputField ValorantHomeSeasonRecordIF;
	public InputField ValorantHomeSeriesScoreIF;
	public InputField ValorantHomePlayer1IF;
	public InputField ValorantHomePlayer2IF;
	public InputField ValorantHomePlayer3IF;
	public InputField ValorantHomePlayer4IF;
	public InputField ValorantHomePlayer5IF;

	public InputField ValorantHomePlayer1StatsIF;
	public InputField ValorantHomePlayer2StatsIF;
	public InputField ValorantHomePlayer3StatsIF;
	public InputField ValorantHomePlayer4StatsIF;
	public InputField ValorantHomePlayer5StatsIF;

	public InputField ValorantTickerIF;
	public InputField ValorantCaster1IF;
	public InputField ValorantCaster2IF;

	public Dropdown ValorantMap1DD;
	public Dropdown ValorantMap2DD;
	public Dropdown ValorantMap3DD;
	public Dropdown ValorantMap4DD;
	public Dropdown ValorantMap5DD;

	public Toggle ValorantHomeMap1Toggle;
	public Toggle ValorantHomeMap2Toggle;
	public Toggle ValorantHomeMap3Toggle;
	public Toggle ValorantHomeMap4Toggle;
	public Toggle ValorantHomeMap5Toggle;

	public InputField ValorantMap1IF;
	public InputField ValorantMap2IF;
	public InputField ValorantMap3IF;
	public InputField ValorantMap4IF;
	public InputField ValorantMap5IF;

	public Toggle ValorantAwayMap1Toggle;
	public Toggle ValorantAwayMap2Toggle;
	public Toggle ValorantAwayMap3Toggle;
	public Toggle ValorantAwayMap4Toggle;
	public Toggle ValorantAwayMap5Toggle;

	public Dropdown ValorantAwayDD;
	public InputField ValorantAwaySeasonRecordIF;
	public InputField ValorantAwaySeriesScoreIF;
	public InputField ValorantAwayPlayer1IF;
	public InputField ValorantAwayPlayer2IF;
	public InputField ValorantAwayPlayer3IF;
	public InputField ValorantAwayPlayer4IF;
	public InputField ValorantAwayPlayer5IF;

	public InputField ValorantAwayPlayer1StatsIF;
	public InputField ValorantAwayPlayer2StatsIF;
	public InputField ValorantAwayPlayer3StatsIF;
	public InputField ValorantAwayPlayer4StatsIF;
	public InputField ValorantAwayPlayer5StatsIF;

	public void ValorantClear()
	{
		ValorantHomeDD.value = 0;
		ValorantHomeSeasonRecordIF.text = "";
		ValorantHomeSeriesScoreIF.text = "0";
		ValorantHomePlayer1IF.text = "";
		ValorantHomePlayer2IF.text = "";
		ValorantHomePlayer3IF.text = "";
		ValorantHomePlayer4IF.text = "";
		ValorantHomePlayer5IF.text = "";

		ValorantHomePlayer1StatsIF.text = "";
		ValorantHomePlayer2StatsIF.text = "";
		ValorantHomePlayer3StatsIF.text = "";
		ValorantHomePlayer4StatsIF.text = "";
		ValorantHomePlayer5StatsIF.text = "";

		ValorantTickerIF.text = "";
		ValorantCaster1IF.text = "";
		ValorantCaster2IF.text = "";

		ValorantMap1DD.value = 0;
		ValorantMap2DD.value = 0;
		ValorantMap3DD.value = 0;
		ValorantMap4DD.value = 0;
		ValorantMap5DD.value = 0;

		ValorantHomeMap1Toggle.isOn = false;
		ValorantHomeMap2Toggle.isOn = false;
		ValorantHomeMap3Toggle.isOn = false;
		ValorantHomeMap4Toggle.isOn = false;
		ValorantHomeMap5Toggle.isOn = false;

		ValorantMap1IF.text = "";
		ValorantMap2IF.text = "";
		ValorantMap3IF.text = "";
		ValorantMap4IF.text = "";
		ValorantMap5IF.text = "";

		ValorantAwayMap1Toggle.isOn = false;
		ValorantAwayMap2Toggle.isOn = false;
		ValorantAwayMap3Toggle.isOn = false;
		ValorantAwayMap4Toggle.isOn = false;
		ValorantAwayMap5Toggle.isOn = false;

		ValorantAwayDD.value = 0;
		ValorantAwaySeasonRecordIF.text = "";
		ValorantAwaySeriesScoreIF.text = "0";
		ValorantAwayPlayer1IF.text = "";
		ValorantAwayPlayer2IF.text = "";
		ValorantAwayPlayer3IF.text = "";
		ValorantAwayPlayer4IF.text = "";
		ValorantAwayPlayer5IF.text = "";

		ValorantAwayPlayer1StatsIF.text = "";
		ValorantAwayPlayer2StatsIF.text = "";
		ValorantAwayPlayer3StatsIF.text = "";
		ValorantAwayPlayer4StatsIF.text = "";
		ValorantAwayPlayer5StatsIF.text = "";
	}
}