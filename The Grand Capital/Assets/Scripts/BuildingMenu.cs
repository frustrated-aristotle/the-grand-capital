using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingMenu : MonoBehaviour
{
    [SerializeField] float border;

	// This is building's workers menu
	public GameObject buildingWorkerMenu;
	public GameObject buildingMainMenu;
	public GameObject workerButton;

	// Update is called once per frame
	void Start()
	{
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
	void OnMouseEnter()
	{
		//we have to make that job inside those panels scripts. 
		//When mouse enter the improvement's collision
		//We have to display menu and its components such as image and button. 
		buildingMainMenu.SetActive(true);
		buildingMainMenu.GetComponent<Image>().enabled = true;
		workerButton.SetActive(true);
	}

    void OnMouseExit()
	{
		buildingMainMenu.SetActive(false);
		buildingWorkerMenu.SetActive(false);
	}
}
