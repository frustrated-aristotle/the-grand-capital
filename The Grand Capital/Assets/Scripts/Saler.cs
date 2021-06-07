using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saler : GlobalMarket
{
	[SerializeField] int whatKindOfSaler;
	public GameObject panel;
	protected override void MarketPanelProperties(int sth)
	{
		base.MarketPanelProperties(whatKindOfSaler);
	}
   
}
