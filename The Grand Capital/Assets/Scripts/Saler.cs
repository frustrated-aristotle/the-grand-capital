using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saler : GlobalMarket
{
	[SerializeField] int whatKindOfSaler;
	[SerializeField] float costOfThing;
	[SerializeField] float durationOfDeal;
	[SerializeField] float speedOfSupply;
	[SerializeField] float theCompencation;

	public GameObject panel;
	protected override void MarketPanelProperties(int sth)
	{
		base.MarketPanelProperties(whatKindOfSaler);
	}
   
}
