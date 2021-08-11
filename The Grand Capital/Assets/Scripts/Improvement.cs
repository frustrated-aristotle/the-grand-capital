using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Improvement : MonoBehaviour
{
    /*
     * Reources are gathered by worker working the improvment with a certain amount that calculated with performance of worker.
     * Gathering rate setted up equal to the player's performance. 
     * There is lots of types of resources, so each of improvements has to be specified. (whatKindOfImprovement)
     * Every improvements has levels: 1,2,3. These are basic levels. 
     * There is merit system here. Each improvements have merit system. In each level up scenario, required merit is going to increase.
     */
    GameObject player;

    public GameObject[] workers =  new GameObject[3];
    [SerializeField] int whatKindOfImprovement;

    public GameObject field;
    [Header("Gathering")]
    public float gatheringAmountOfWorkers;
    public float totalGatheringAmount;
    [Header("Level of Improvement")]
    public int certainLevel = 0;
    int i = 0;

    public int workersnum;

    [Header("Merit")]
    public float reqMerit;

    [Header("Worker")]
    public List<GameObject> wrk = new List<GameObject>();

    void Start()
    {
        InvokeRepeating("MakeRawMaterial", 0f, 1f);
        player = GameObject.Find("Player");
    }

    void FixedUpdate()
	{
        //Calculating Gathering Amount
        {
			for (int i = 0; i < wrk.Count; i++)
			{
				if (wrk[i] != null)
				{
                    gatheringAmountOfWorkers = wrk[i].GetComponent<Worker>().workerPerformance;
                    wrk[i].GetComponent<Worker>().workerTalentPoint += wrk[i].GetComponent<Worker>().workerPerformance;
                    Debug.Log("s");

                }
			}
        }

        //Delete it when everything worked.
        {
        /*
            if (workers[0] != null)
            {
                Debug.Log(workers[0].GetComponent<Worker>().workerPerformance);
            }
        */
        }
	}

    public void AssignAsWorker(GameObject worker)
	{
        wrk.Add(worker);
        
	}
    //If player wants to increse his worker amount, this will help him or her
    public void IncreaseWorkerAmount()
	{
        //It's about level of the improvement.
	}

    public void DecreaseWorkerAmount()
    {
        //It's about the level of the improvement.
    }
    public void MakeRawMaterial()
	{
        switch (whatKindOfImprovement)
        {
            // 0: Farm || 1: Mine || 2: Lumber Mill || 3: Fishing Port || 4: Energy || 5: Fossil || 6: Space Mining
            case 0:
                player.GetComponent<PlayerResources>().rawMatAgriculture+= gatheringAmountOfWorkers;
                break;
            case 1:
                player.GetComponent<PlayerResources>().rawMatMining+= gatheringAmountOfWorkers;
                break;
            case 2:
                player.GetComponent<PlayerResources>().rawMatForestry += gatheringAmountOfWorkers;
                break;
            case 3:
                player.GetComponent<PlayerResources>().rawMatWater += gatheringAmountOfWorkers;
                break;
            case 4:
                player.GetComponent<PlayerResources>().rawMatEnergy += gatheringAmountOfWorkers;
                break;
            case 5:
                player.GetComponent<PlayerResources>().rawMatFossil += gatheringAmountOfWorkers;
                break;
            case 6:
                player.GetComponent<PlayerResources>().rawMatSpaceMining += gatheringAmountOfWorkers;
                break;
        }
      
        //This switch-case fonction will be used when we decide about the level issue:
		{
      /*
        {
            switch (i)
            {
                case 0:
                    //This improvement is first level, therefore it can only make that:
                    break;

                case 1:
                    //This improvement is second level, therefore it can only make that:
                    break;
                case 2:
                    //This improvement is third level, therefore it can only make that:
                    break;
            }
        }
        */	
      }
    }
}
