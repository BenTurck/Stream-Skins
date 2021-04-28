using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHide : MonoBehaviour
{
	public GameObject OverwatchObject;
	public GameObject SmashBrosObject;
	public GameObject LeagueofLegendsObject;
	public GameObject CustomObject;
	public GameObject AssetsObject;
	public GameObject MMObject;
	//public GameObject StatsObject;



	void Start()
	{
		OverwatchObject.SetActive(false);
		SmashBrosObject.SetActive(false);
		LeagueofLegendsObject.SetActive(false);
		CustomObject.SetActive(false);
		AssetsObject.SetActive(false);
		MMObject.SetActive(false);
		//StatsObject.SetActive(false);
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
