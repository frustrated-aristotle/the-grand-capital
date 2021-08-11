using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    public GameObject s;
    public GameObject whichBuilding;
    //Name	Exp	Tlt		Qua	Tired	Relax	Shelter	Bos	angr But we already have them. 

    [Header("Production")]
    public float workerExprience;
    public float workerTalent;
    public float workerQualification;
    public float workerPerformance;
    public float workerSuitability;

    public float workerTalentPoint;

    [Header("Life")]
    public float workerHappinnes;
    public float workerSheltering;
    public float workerResting;
    
    [Header("Social")]
    public float workerAffection;
    public float workerOpinion;


    [Header("Worker Angry")]
    [SerializeField] float workerAngry;

    [Header("Worker Personal Properties")]
    [SerializeField] string workerName;
    public GameObject workersParent;
    public GameObject parent;

    [Header("Work Place")]
    public GameObject workplace;
    //When a worker have a workplace, that workplace have to assign this worker as its own worker.
    //When all of them happend, isWorking have to be assing as true, because it will have assigned. 

    public bool isWorking = false;

	void Start()
	{
        Debug.Log("BBBB");
       parent=this.transform.parent.GetComponent<SelectWorkerMenu>().mainParent;
	}

    public void AssignWorkerForThatBuilding()
	{
        this.transform.SetParent(parent.transform);
        parent.GetComponent<Improvement>().AssignAsWorker(this.gameObject);
        // parent.transform.GetComponent<Improvement>().workers[0]=this.gameObject;
        isWorking = true;
        //  this.transform.SetParent(this.transform.parent.gameObject.GetComponent<SelectWorkerMenu>().mainParent.transform);
       // workersParent = this.transform.parent.GetComponent<SelectWorkerMenu>().mainParent;
        //this.transform.SetParent(workersParent.transform);
    }
}
