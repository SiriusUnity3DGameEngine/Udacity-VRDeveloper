using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

	public GameObject top; 

	public void OnChestClicked(){

		top.transform.Rotate (50f, 0f, 0f);
		
	}
}
