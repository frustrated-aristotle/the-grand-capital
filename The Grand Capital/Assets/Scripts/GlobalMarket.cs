using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMarket : MonoBehaviour
{

	protected int whichMaterial;
	protected int whichProcessedMaterial;
	protected int whichProduct;
	protected int whichProcessedProduct;

	protected float whichMaterialCost;
	protected float whichProcessedMaterialCost;
	protected float whichProductCost;
	protected float whichProcessedProductCost;

	void Start()
	{
		MarketPanelProperties(1);
	}
	protected virtual void A()
	{
		
	}

	protected virtual void MarketPanelProperties(int whatKindOfSaler)
	{
		switch (whatKindOfSaler)
		{
			//0=Material && 1=Processed Material && 2=Product && 3=Processed Product
			case 0:
				//What kind of thing you want to sell
				Debug.Log("Sell: Material");
				//What is the cost of buying that thing
				Debug.Log("Cost: x");
				//What is the speed
				Debug.Log("Speed: y");
				//What is the duration
				Debug.Log("Duration: z");
				//What is the compensation
				Debug.Log("Compensation: idk");
				break;
			case 1:
				Debug.Log("nothing");
				break;
			case 2:

				break;
			case 3:

				break;
		}
	}

}
