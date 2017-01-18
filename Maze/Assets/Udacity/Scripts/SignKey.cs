using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignKey : MonoBehaviour {

	public GameObject emergeKey;

	public void OnKeyClicked()
	{

		// Move the wall and reveal the key
		//transform.Translate (0, -10f * Time.deltaTime, 0, Space.World);
		//Destroy the wall
		Destroy(gameObject);

	}
}
