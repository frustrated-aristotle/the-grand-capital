using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
	public GameObject improvementGameObject;
	public GameObject factoryGameObject;

	public bool isPlaced = false;

	public bool forImprovement;
	

	public bool forFarm;
	public bool forFishingPort;
	public bool forMine;
	public bool forLumberMill;

	//You can place your factory wherever you want. 
	public bool forFactory;
	public bool forSeaFactory;
	public bool forScience;

	public Renderer rend;
	Color groundBaseColor;
	void Start()
	{
		rend = GetComponent<Renderer>();
		groundBaseColor = rend.material.color;
		rend.material.color = groundBaseColor;
	}
	public void OnMouseEnter()
	{
		rend.material.color = Color.grey;
	}

	public void OnMouseExit() 
	{
		rend.material.color = groundBaseColor;
	}
	public void OnMouseDown()
	{
		//If there is no 
		if (!isPlaced && forImprovement)
		{
			isPlaced = true;
			//Is this place suitable for Improvement?

			//Then Build the Improvement right here:
			//BuildImprovement();

			//Theb Build the Factory1 right here:
			BuildFactory();
		}
	}

	public void BuildImprovement()
	{
		Instantiate(improvementGameObject, this.gameObject.transform.position, Quaternion.identity);
	}
	public void BuildFactory()
	{
		Instantiate(factoryGameObject, this.gameObject.transform.position, Quaternion.identity);
	}
}
