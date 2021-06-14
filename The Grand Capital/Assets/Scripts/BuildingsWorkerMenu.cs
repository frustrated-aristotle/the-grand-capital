using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingsWorkerMenu : MonoBehaviour
{
	// This is building's workers menu
	public GameObject buildingWorkerMenu;
	public GameObject buildingMainMenu;
	public GameObject workerButton;
	
	public void ShowBuildingsWorkers()
	{
		//When player click the "Workers" button, game display The Building's Workers Menu:
		buildingWorkerMenu.SetActive(true);

		//We have to deactive image componenet of Main Building Info Menu:
		buildingMainMenu.GetComponent<Image>().enabled = false;
		//Then we have to completely deactive The Button that we clicked to make all of those activities.
		workerButton.SetActive(false);
	}
	
}
