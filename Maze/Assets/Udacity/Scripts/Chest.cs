using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

	public GameObject top; 
	public GameObject chestCollider;
	public GameObject chestPoof;

	public void OnChestClicked(){
		
		Instantiate(chestPoof,transform.position, Quaternion.Euler(-150,0,0));
		top.transform.Rotate (35f, 0f, 0f);
		Destroy (chestCollider);
		
	}
}
