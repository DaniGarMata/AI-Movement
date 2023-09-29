using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class wander : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    public float radius, offset;

    void Update()
    {
        Vector3 localTarget = UnityEngine.Random.insideUnitCircle * radius;
        localTarget += new Vector3(0, 0, offset);
        Vector3 worldTarget = transform.TransformPoint(localTarget);
        worldTarget.y = 0f;

        Seek(worldTarget);
        
    }

    void Seek(Vector3 v)
    {
        agent.destination = v;
    }
}
