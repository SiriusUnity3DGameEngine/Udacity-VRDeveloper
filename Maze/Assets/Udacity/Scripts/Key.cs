using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public Door doorOpen;
	public static bool gotKey;

	public void OnKeyClicked()
	{
		
    // Instatiate the KeyPoof Prefab where this key is located
    // Make sure the poof animates vertically
    Instantiate(keyPoof,transform.position,Quaternion.Euler(-150,0,0));
	gotKey = true;

    // Call the Unlock() method on the Door
    doorOpen.Unlock();
    // Destroy the key and play unlock sound
    Destroy(gameObject);
	
		}
    
}
