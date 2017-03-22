using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 

    public bool unlocked;
    public AudioSource doorSound;
	public AudioClip openGate;
	public AudioClip closedGate;
	public GameObject leftDoor;
	public GameObject rightDoor;
	public GameObject collider1;


	public void OnDoorClicked(){
		//
		if (Key.gotKey == true) {
			//transform.Translate (0, 15f, 0, Space.World);
			leftDoor.transform.Rotate (0f, 0f, 80f);
			rightDoor.transform.Rotate (0f, 0f, -80f);
			Destroy(collider1);
			doorSound.PlayOneShot (openGate);
		} else {
			doorSound.PlayOneShot (closedGate);
		}

	}
		
    public void Unlock()
    {
	unlocked = true;
    }
}