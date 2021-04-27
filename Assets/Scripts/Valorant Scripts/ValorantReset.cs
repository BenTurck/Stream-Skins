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

	public InputField ValorantTickerIF;
	public InputField ValorantCaster1IF;
	public InputField ValorantCaster2IF;

	public Toggle ValorantHomeMap1Toggle;
	public Toggle ValorantHomeMap2Toggle;
	public Toggle ValorantHomeMap3Toggle;
	public Toggle ValorantHomeMap4Toggle;
	public Toggle ValorantHomeMap5Toggle;

	public InputField ValorantHomeMap1IF;
	public InputField ValorantHomeMap2IF;
	public InputField ValorantHomeMap3IF;
	public InputField ValorantHomeMap4IF;
	public InputField ValorantHomeMap5IF;

	public Dropdown ValorantMap1DD;
	public Dropdown ValorantMap2DD;
	public Dropdown ValorantMap3DD;
	public Dropdown ValorantMap4DD;
	public Dropdown ValorantMap5DD;

	public InputField ValorantAwayMap1IF;
	public InputField ValorantAwayMap2IF;
	public InputField ValorantAwayMap3IF;
	public InputField ValorantAwayMap4IF;
	public InputField ValorantAwayMap5IF;

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

		ValorantTickerIF.text = "";
		ValorantCaster1IF.text = "";
		ValorantCaster2IF.text = "";

		ValorantHomeMap1Toggle.isOn = false;
		ValorantHomeMap2Toggle.isOn = false;
		ValorantHomeMap3Toggle.isOn = false;
		ValorantHomeMap4Toggle.isOn = false;
		ValorantHomeMap5Toggle.isOn = false;

		ValorantHomeMap1IF.text = "";
		ValorantHomeMap2IF.text = "";
		ValorantHomeMap3IF.text = "";
		ValorantHomeMap4IF.text = "";
		ValorantHomeMap5IF.text = "";

		ValorantMap1DD.value = 0;
		ValorantMap2DD.value = 0;
		ValorantMap3DD.value = 0;
		ValorantMap4DD.value = 0;
		ValorantMap5DD.value = 0;

		ValorantAwayMap1IF.text = "";
		ValorantAwayMap2IF.text = "";
		ValorantAwayMap3IF.text = "";
		ValorantAwayMap4IF.text = "";
		ValorantAwayMap5IF.text = "";

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
	}
}