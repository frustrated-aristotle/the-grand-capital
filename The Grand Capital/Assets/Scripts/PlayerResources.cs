using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResources : MonoBehaviour
{
	[Header("Player's Things")]
	public float playerWorker;
	public float playerMoney;
	public float playerScience;

	[Header("Player's Raw Materials")]
	public float rawMatAgriculture;
	public float rawMatMining;
	public float rawMatForestry;
	public float rawMatWater;
	public float rawMatEnergy;
	public float rawMatFossil;
	public float rawMatSpaceMining;

	[Header("Player's Materials")]
	public float matAgriculture;
	public float matMining;
	public float matForestry;
	public float matWater;
	public float matEnergy;
	public float matFossil;
	public float matSpaceMining;
	[Header("Player's Goods")]

	public float goodAgriculture;
	public float goodMining;
	public float goodForestry;
	public float goodWater;
	public float goodEnergy;
	public float goodFossil;
	public float goodSpaceMining;

	[Header("Player's Processed Goods")]
	public float playerProcessedAgriculture;
	public float playerProcessedOre;
	public float playerProcessedLumber;
	public float playerProcessedFish;
	public float playerProcessedEnergy;
	public float playerProcessedFossil;
	public float playerProcessedSpaceOre;

	public Salers saler;
	//[Header("Player's Products")]
	//[Header("Player's Processed Products")]
	public GameObject[] workers;

	void Start()
	{
		
	}
	void Update()
	{
		Debug.Log(rawMatAgriculture);
	}



}
