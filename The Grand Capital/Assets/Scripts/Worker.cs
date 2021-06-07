using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
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


}
