using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
	public GameObject endScreen;

	private void Start()
	{
		if (endScreen != null)
			endScreen = Instantiate(endScreen);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player") && endScreen != null)
        {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			endScreen.SetActive(true);
        }
	}
}
