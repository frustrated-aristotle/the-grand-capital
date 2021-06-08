using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Saler" , menuName = "Salers")]
public class Salers : ScriptableObject
{
	
	//0=Material && 1=Processed Material && 2=Product && 3=Processed Product
	[SerializeField] int whatKindOfSaler;
	[SerializeField] float costOfThing;
	[SerializeField] float durationOfDeal;
	[SerializeField] float speedOfSupply;
	[SerializeField] float theCompencation;
	public GameObject panel;

	NewThings nt = new NewThings();
	
	

	public class NewThings : GlobalMarket
	{
		Salers saler = new Salers();
		protected override void MarketPanelProperties(int sth)
		{
			base.MarketPanelProperties(saler.whatKindOfSaler);
		}
	}
}

