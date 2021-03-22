using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
	public GameObject modle;

	bool pickedUp;

	public static int counter;
	PickUpCounter pc;

	private void Start()
	{
		pc = GameObject.Find("Canvas").GetComponent<PickUpCounter>();

		if (modle == null)
			modle = gameObject;
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player") && !pickedUp)
		{
			counter++;
			pickedUp = true;
			pc.IncreaseCounter();
			modle.SetActive(false);
		}
	}
}
