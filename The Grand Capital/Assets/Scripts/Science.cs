using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Science : MonoBehaviour
{
    GameObject player;
    [SerializeField] int whatKindOfScience  ;
    public float makingRate = 2f;

    public int certainLevel = 0;
    public float makingAmount = 5;
    int i = 0;
    void Start()
    {
        InvokeRepeating("MakeRawMaterial", 0f, makingRate);
        player = GameObject.Find("Player");
    }

    public void MakeRawMaterial()
    {
        switch (whatKindOfScience)
        {
            // 0: Farm || 1: Mine || 2: Lumber Mill || 3: Fishing Port
            case 0:
                player.GetComponent<PlayerResources>().playerScience += makingAmount;
                break;
            //We can add some other features but I'm not sure about it. We haven't think already about it. 
        }
    }
}
