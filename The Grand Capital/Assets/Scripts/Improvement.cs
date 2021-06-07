using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Improvement : MonoBehaviour
{
    GameObject player;
    [SerializeField] int whatKindOfImprovement;
    public float makingRate=2f;

    public GameObject field;

    public int certainLevel = 0;
    public float makingAmount=5;
    int i = 0;
    void Start()
    {
        InvokeRepeating("MakeRawMaterial", 0f, makingRate);
        player = GameObject.Find("Player");
    }

    //If player wants to increse his worker amount, this will help him or her
    public void IncreaseWorkerAmount()
	{

	}

    public void DecreaseWorkerAmount()
    {

    }
    public void MakeRawMaterial()
	{
        switch (whatKindOfImprovement)
        {
            // 0: Farm || 1: Mine || 2: Lumber Mill || 3: Fishing Port
            case 0:
                player.GetComponent<PlayerResources>().playerFruit+= makingAmount;
                break;
            case 1:
                player.GetComponent<PlayerResources>().playerOre += makingAmount;
                break;
            case 2:
                player.GetComponent<PlayerResources>().playerLumber += makingAmount;
                break;
            case 3:
                player.GetComponent<PlayerResources>().playerFish += makingAmount;
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
