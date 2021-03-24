using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum AIState
{
    Idle, // Doesn't know where the player is
    Alert, // Knows the player is in the room
    Attack // Knows where the player is and is moving to kill
}


public class ChildAI : MonoBehaviour
{
    public Transform[] waypointRooms;
    public NavMeshAgent agent;

	public float timeInRoom;
	public float timeInRoomWithPlayer;

	public float moveSpeed;
	public float speedWithPlayerInRoom;

	public float timeAtWaypoint;
	public float timeAtWaypointWithPlayer;


	private float eTimeRoom;
	private float eTimeRoomPlayer;

	private float eTimeWaypoint;
	private float eTimeWayPlayer;


    // Update is called once per frame
    void Update()
    {
		SwitchState(AIState.Idle);
	}

	public void SwitchState(AIState state)
	{
		switch (state)
		{
			case AIState.Idle:
				Idle();
				break;
			case AIState.Alert:
				Alert();
				break;
			case AIState.Attack:
				Attack();
				break;
		}
	}


    public void Idle()
	{
		// Child is in the same room as the player
		if (EntityFinder.ChildLocation == EntityFinder.PlayerLocation)
		{
			// Pick a random waypoint in that room and stay there for a few seconds



		}
		else
		{

		}
	}

    public void Alert()
	{

	}

    public void Attack()
	{

	}
}
