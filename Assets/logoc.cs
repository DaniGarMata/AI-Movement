using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class logoc : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;

    void Update()
    {
        agent.destination = target.position;        
    }
}
