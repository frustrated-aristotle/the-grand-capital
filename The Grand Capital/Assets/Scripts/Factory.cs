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
    int i = 0;
    void Start()
    {
        InvokeRepeating("MakeProcessedMaterial", 0f, makingRate);
        player = GameObject.Find("Player");


    }

    public void MakeProcessedMaterial()
    {
        //In that function, we make some processed fruit by processing raw materials in this case, fruits. 
        switch (whatKindOfFactory)
        {
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
