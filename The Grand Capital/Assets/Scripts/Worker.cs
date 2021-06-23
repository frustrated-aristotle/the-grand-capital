using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    public GameObject s;
    public GameObject whichBuilding;
    //Name	Exp	Tlt		Qua	Tired	Relax	Shelter	Bos	angr But we already have them. 

    [Header("Production")]
    [SerializeField] float workerExprience;
    [SerializeField] float workerTalent;
    [SerializeField] float workerQualification;

    [Header("Life")]
    [SerializeField] float workerHappinnes;
    [SerializeField] float workerTiredness;
    [SerializeField] float workerSheltering;
    [SerializeField] float workerRelaxing;
    [SerializeField] float workerBoss;

    [Header("Worker Angry")]
    [SerializeField] float workerAngry;

    [Header("Worker Personal Properties")]
    [SerializeField] string workerName;
    public GameObject workersParent;

	void Start()
	{
        
	}

    public void AssignWorkerForThatBuilding()
	{
        this.transform.SetParent(this.transform.parent.gameObject.GetComponent<SelectWorkerMenu>().mainParent.transform);
        Debug.Log("dsfa");
    }
}
