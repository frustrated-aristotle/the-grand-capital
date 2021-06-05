using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
	public GameObject improvementGameObject;

	public bool isPlaced = false;

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
		if (isPlaced==false)
		{
			isPlaced = true;
			BuildImprovement();
		}
	}

	public void BuildImprovement()
	{
		Instantiate(improvementGameObject, this.gameObject.transform.position, Quaternion.identity);
	}
}
