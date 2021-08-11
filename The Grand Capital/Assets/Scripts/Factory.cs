using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{

    GameObject player;
    [SerializeField] int whatKindOfFactory;
    public float makingRate = 2f;
    public float spendingRate = 2f;
    public int certainLevel = 0;
    public float makingAmount = 5;

    [Header("Factory's")]
    float factoryLvl;

    [Header("Worker")]
    public float gatheringAmountOfWorkers;

    public List<GameObject> workers = new List<GameObject>();
    void Start()
    {
        InvokeRepeating("MakeProcessedMaterial", 0f, makingRate);
        player = GameObject.Find("Player");

    }

    void FixedUpdate()
	{
		//Calculate Produce Amount
		{
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i] != null)
                {
                    gatheringAmountOfWorkers = workers[i].GetComponent<Worker>().workerPerformance;
                   
                }
            }

        }
	}
    public void AssignAsWorker(GameObject worker)
    {
        workers.Add(worker);

    }

    public void MakeProcessedMaterial()
    {

        /*Factory gets it's reources from player's resources. 
         *If the amount of reources is equal or bigger than necessary amount, factory works.
         *If it is not, factory have to wait. 
         */
        switch (whatKindOfFactory)
        {
            // 0: Farm || 1: Mine || 2: Lumber Mill || 3: Fishing Port || 4: Energy || 5: Fossil || 6: Space Mining
            //Producing:        0     |\|      1      |\|           2 
            //          rawMat -> mat |\| mat -> good |\| good -> processed good
            case 0:
                for (int i = 0; i < workers.Count; i++)
                {
                    if (player.GetComponent<PlayerResources>().rawMatAgriculture >= workers[i].GetComponent<Worker>().workerPerformance*2)
                    {
                        player.GetComponent<PlayerResources>().rawMatAgriculture -= workers[i].GetComponent<Worker>().workerPerformance;
                        player.GetComponent<PlayerResources>().matAgriculture += workers[i].GetComponent<Worker>().workerPerformance;
                        
                        workers[i].GetComponent<Worker>().workerTalentPoint += workers[i].GetComponent<Worker>().workerPerformance;
                        if (workers[i].GetComponent<Worker>().workerTalentPoint >= 5000)
                        {
                            workers[i].GetComponent<Worker>().workerTalentPoint -= 5000;
                            workers[i].GetComponent<Worker>().workerTalent += 1;
                        }
                    }
                }
                break;
            case 1:
                for (int i = 0; i < workers.Count; i++)
                {
                    if (player.GetComponent<PlayerResources>().rawMatMining >= workers[i].GetComponent<Worker>().workerPerformance*2)
                    {
                        player.GetComponent<PlayerResources>().rawMatAgriculture -= workers[i].GetComponent<Worker>().workerPerformance;
                        player.GetComponent<PlayerResources>().matMining += workers[i].GetComponent<Worker>().workerPerformance;
                    }

                    workers[i].GetComponent<Worker>().workerTalentPoint += workers[i].GetComponent<Worker>().workerPerformance;
                    if (workers[i].GetComponent<Worker>().workerTalentPoint >= 5000)
                    {
                        workers[i].GetComponent<Worker>().workerTalentPoint -= 5000;
                        workers[i].GetComponent<Worker>().workerTalent += 1;
                    }
                }
                break;
            case 2:
                for (int i = 0; i < workers.Count; i++)
                {
                    if (player.GetComponent<PlayerResources>().rawMatForestry >= workers[i].GetComponent<Worker>().workerPerformance *2)
                    {
                        player.GetComponent<PlayerResources>().rawMatForestry-= workers[i].GetComponent<Worker>().workerPerformance;
                        player.GetComponent<PlayerResources>().matForestry += workers[i].GetComponent<Worker>().workerPerformance;
                    }

                    workers[i].GetComponent<Worker>().workerTalentPoint += workers[i].GetComponent<Worker>().workerPerformance;
                    if (workers[i].GetComponent<Worker>().workerTalentPoint >= 5000)
                    {
                        workers[i].GetComponent<Worker>().workerTalentPoint -= 5000;
                        workers[i].GetComponent<Worker>().workerTalent += 1;
                    }
                }
                break;
            case 3:
                for (int i = 0; i < workers.Count; i++)
                {
                    if (player.GetComponent<PlayerResources>().rawMatWater >= workers[i].GetComponent<Worker>().workerPerformance*2)
                    {
                        player.GetComponent<PlayerResources>().rawMatWater-= workers[i].GetComponent<Worker>().workerPerformance;
                        player.GetComponent<PlayerResources>().matWater += workers[i].GetComponent<Worker>().workerPerformance;
                    }

                    workers[i].GetComponent<Worker>().workerTalentPoint += workers[i].GetComponent<Worker>().workerPerformance;
                    if (workers[i].GetComponent<Worker>().workerTalentPoint >= 5000)
                    {
                        workers[i].GetComponent<Worker>().workerTalentPoint -= 5000;
                        workers[i].GetComponent<Worker>().workerTalent += 1;
                    }
                }
                break;
            case 4:
                for (int i = 0; i < workers.Count; i++)
                {
                    if (player.GetComponent<PlayerResources>().rawMatEnergy>= workers[i].GetComponent<Worker>().workerPerformance*2)
                    {
                        player.GetComponent<PlayerResources>().rawMatEnergy-= workers[i].GetComponent<Worker>().workerPerformance;
                        player.GetComponent<PlayerResources>().matEnergy+= workers[i].GetComponent<Worker>().workerPerformance;
                    }

                    workers[i].GetComponent<Worker>().workerTalentPoint += workers[i].GetComponent<Worker>().workerPerformance;
                    if (workers[i].GetComponent<Worker>().workerTalentPoint >= 5000)
                    {
                        workers[i].GetComponent<Worker>().workerTalentPoint -= 5000;
                        workers[i].GetComponent<Worker>().workerTalent += 1;
                    }
                }
                break;
            case 5:
                for (int i = 0; i < workers.Count; i++)
                {
                    if (player.GetComponent<PlayerResources>().rawMatFossil >= workers[i].GetComponent<Worker>().workerPerformance*2)
                    {
                        player.GetComponent<PlayerResources>().rawMatFossil-= workers[i].GetComponent<Worker>().workerPerformance;
                        player.GetComponent<PlayerResources>().matFossil += workers[i].GetComponent<Worker>().workerPerformance;
                    }

                    workers[i].GetComponent<Worker>().workerTalentPoint += workers[i].GetComponent<Worker>().workerPerformance;
                    if (workers[i].GetComponent<Worker>().workerTalentPoint >= 5000)
                    {
                        workers[i].GetComponent<Worker>().workerTalentPoint -= 5000;
                        workers[i].GetComponent<Worker>().workerTalent += 1;
                    }
                }
                break;
            case 6:
                for (int i = 0; i < workers.Count; i++)
                {
                    if (player.GetComponent<PlayerResources>().rawMatSpaceMining >= workers[i].GetComponent<Worker>().workerPerformance*2)
                    {
                        player.GetComponent<PlayerResources>().rawMatSpaceMining -= workers[i].GetComponent<Worker>().workerPerformance;
                        player.GetComponent<PlayerResources>().matSpaceMining+= workers[i].GetComponent<Worker>().workerPerformance;
                    }

                    workers[i].GetComponent<Worker>().workerTalentPoint += workers[i].GetComponent<Worker>().workerPerformance;
                    if (workers[i].GetComponent<Worker>().workerTalentPoint >= 5000)
                    {
                        workers[i].GetComponent<Worker>().workerTalentPoint -= 5000;
                        workers[i].GetComponent<Worker>().workerTalent += 1;
                    }
                }
                break;
        }



        //In that function, we make some processed fruit by processing raw materials in this case, fruits. 

        {
            /*
        switch (whatKindOfFactory)
            // 0: Farm || 1: Mine || 2: Lumber Mill || 3: Fishing Port
            // We have to check the amount of raw material whether it is enough or not to process fruit.
            case 0:
				if (player.GetComponent<PlayerResources>().playerFruit >= spendingRate)
                {
                    player.GetComponent<PlayerResources>().playerFruit -= spendingRate;
                    player.GetComponent<PlayerResources>().playerProcessedFruit += makingAmount;
				}
                break;

            case 1:
                if (player.GetComponent<PlayerResources>().playerOre >= spendingRate)
                {
                    player.GetComponent<PlayerResources>().playerOre -= spendingRate;
                    player.GetComponent<PlayerResources>().playerProcessedOre += makingAmount;
                }
                break;

            case 2:
                if (player.GetComponent<PlayerResources>().playerLumber >= spendingRate)
                {
                    player.GetComponent<PlayerResources>().playerLumber -= spendingRate;
                    player.GetComponent<PlayerResources>().playerProcessedLumber += makingAmount;
                }
                break;

            case 3:
                if (player.GetComponent<PlayerResources>().playerFish >= spendingRate)
                {
                    player.GetComponent<PlayerResources>().playerFish -= spendingRate;
                    player.GetComponent<PlayerResources>().playerProcessedFish += makingAmount;
                }
                break;
        }
        */
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
}
