using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 

	bool unlocked;
    public AudioSource doorSound;
	public AudioClip openGate;
	public AudioClip closedGate;



	public void OnDoorClicked(){
		//
		if (Key.gotKey == true) {
			transform.Translate (0, 12f, 0, Space.World);
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