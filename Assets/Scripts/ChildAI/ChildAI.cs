using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ChildAI : MonoBehaviour
{
    public Transform waypointList;
    public NavMeshAgent agent;

    public float stayTime;
    private float endStayTime;


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= endStayTime)
		{
            endStayTime = Time.time + stayTime;

            // travel to random waypoint
            agent.SetDestination(waypointList.GetChild(Random.Range(0, waypointList.childCount)).position);
		}
    }
}
