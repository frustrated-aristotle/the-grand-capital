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
	public float playerFruit;
	public float playerOre;
	public float playerLumber;
	public float playerFish;

	[Header("Player's Processed Materials")]
	public float playerProcessedFruit;
	public float playerProcessedOre;
	public float playerProcessedLumber;
	public float playerProcessedFish;

	public Salers saler;
	//[Header("Player's Products")]
	//[Header("Player's Processed Products")]
	public GameObject[] workers;

	void Start()
	{
		
	}



}
