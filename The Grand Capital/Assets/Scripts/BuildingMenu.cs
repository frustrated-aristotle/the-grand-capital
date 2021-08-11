using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingMenu : MonoBehaviour
{
	GameObject player;
	public GameObject mainParent;
	public GameObject whichPlayer;
	GameObject reassingWorkersParent;
	
	[SerializeField] float border;
	
	[Header("Building Main Menu")]
	//
	public GameObject buildingMainMenu;

	[Header("Building Worker Info Menu")]
	// This is building's workers menu
	public GameObject buildingWorkerMenu;
	public GameObject workerButton;

	[Header("Building's Sellect Worker Menu")]
	//
	public GameObject buildingSellectWorkerMenu;
	public GameObject sellectWorkerButton;

	// Update is called once per frame
	void Awake()
	{
		buildingMainMenu.transform.SetParent(GameObject.Find("Canvas").transform);
	}
	void Start()
	{
		player = GameObject.Find("Player");	
		Vector3 menuPos = Camera.main.WorldToScreenPoint(this.transform.position);

		reassingWorkersParent = GameObject.Find("Workers");

		buildingMainMenu.transform.position = menuPos;
	}
	public void ShowBuildingsWorkers()
	{
		//When player click the "Workers" button, game display The Building's Workers Menu:
		buildingWorkerMenu.SetActive(true);

		//We have to deactive image componenet of Main Building Info Menu:
		buildingMainMenu.GetComponent<Image>().enabled = false;
		//Then we have to completely deactive The Button that we clicked to make all of those activities.
		workerButton.SetActive(false);
	}

	public void ShowSellectWorkerMenu()
	{
		//When player click the "Sellect Worker" button, game display the Sellect Worker Menu:
		buildingSellectWorkerMenu.SetActive(true);

		//We have deactive image companent of Main Building Info Menu:
		buildingMainMenu.GetComponent<Image>().enabled = false;

		//Then we have to completely deactive The Button that we clicked to make all of those activities.
		sellectWorkerButton.SetActive(false);

		//We have to display player's worker that exists.
		
		for (int i = 0; i < player.GetComponent<PlayerResources>().workers.Length; i++)
		{
			//We can use if statement here if we have to not display all of the workers whether they are working or not.

			if (!player.GetComponent<PlayerResources>().workers[i].GetComponent<Worker>().isWorking)
			{
			/*We are setting a parent to each workers that exist. The parent is building's worker sellection menu
			 *Because actually we have to display properties of workers in the sellection menu.
			 *We have text component to text properties of it. 
			 */
				Debug.Log("sssss"+player.GetComponent<PlayerResources>().workers.Length);
				player.GetComponent<PlayerResources>().workers[i].transform.SetParent(buildingSellectWorkerMenu.transform);
				player.GetComponent<PlayerResources>().workers[i].SetActive(true);
			//We setted up the parent to our worker for just displaying them. When we clicked on them, we have to make reset it as it has to. 
			}
			
			
		}

		//I'm not sure what it is.
		{ 
		/*
		player.GetComponent<PlayerResources>().workers[0].SetActive(true);
		player.GetComponent<PlayerResources>().workers[1].SetActive(true);

		player.GetComponent<PlayerResources>().workers[0].GetComponent<Worker>().workersParent = mainParent;
		player.GetComponent<PlayerResources>().workers[1].GetComponent<Worker>().workersParent = mainParent;
		//mainParent.GetComponent<Improvement>().workers[0] = player.GetComponent<PlayerResources>().workers[0];
		//mainParent.GetComponent<Improvement>().workers[1] = player.GetComponent<PlayerResources>().workers[1];


		player.GetComponent<PlayerResources>().workers[0].transform.SetParent(buildingSellectWorkerMenu.transform);		
		player.GetComponent<PlayerResources>().workers[1].transform.SetParent(buildingSellectWorkerMenu.transform);
		whichPlayer = this.gameObject;
		*/}
	}
	void OnMouseEnter()
	{
		//we have to make that job inside those panels scripts. 
		//When mouse enter the improvement's collision
		//We have to display menu and its components such as image and button. 
		buildingMainMenu.SetActive(true);
		buildingMainMenu.GetComponent<Image>().enabled = true;
		workerButton.SetActive(true);
		sellectWorkerButton.SetActive(true);
		
	}

    void OnMouseExit()
	{
		buildingMainMenu.SetActive(false);
		buildingWorkerMenu.SetActive(false);
		buildingSellectWorkerMenu.SetActive(false);
		whichPlayer = null;

		//We can not store our player's workers in specified menu, thus we have to reassign their parents as what it was.
		//We can use similar "for" codes.
		for (int i = 0; i < player.GetComponent<PlayerResources>().workers.Length; i++)
		{
			//We have to control whether the worker is working or not:
			if (!player.GetComponent<PlayerResources>().workers[i].GetComponent<Worker>().isWorking)
			{
				player.GetComponent<PlayerResources>().workers[i].transform.SetParent(reassingWorkersParent.transform);
				player.GetComponent<PlayerResources>().workers[i].SetActive(false);
			}
		}
	}

}
