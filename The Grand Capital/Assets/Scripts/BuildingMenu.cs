using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingMenu : MonoBehaviour
{
	GameObject player;
	public GameObject mainParent;
	public GameObject whichPlayer;
	
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


		player.GetComponent<PlayerResources>().workers[0].SetActive(true);
		player.GetComponent<PlayerResources>().workers[1].SetActive(true);
		player.GetComponent<PlayerResources>().workers[0].GetComponent<Worker>().workersParent = mainParent;
		player.GetComponent<PlayerResources>().workers[1].GetComponent<Worker>().workersParent = mainParent;


		player.GetComponent<PlayerResources>().workers[0].transform.SetParent(buildingSellectWorkerMenu.transform);		
		player.GetComponent<PlayerResources>().workers[1].transform.SetParent(buildingSellectWorkerMenu.transform);
		whichPlayer = this.gameObject;
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
	}

}
