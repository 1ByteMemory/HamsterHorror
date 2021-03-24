using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFinder : MonoBehaviour
{
    public static Transform PlayerLocation;
    public static Transform ChildLocation;


	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			PlayerLocation = transform;
		}

		if (other.CompareTag("Child"))
		{
			ChildLocation = transform;
		}
	}
}
