using UnityEngine;
using System.Collections;

public class MoveAirplane : MonoBehaviour {

	public float interval;
	private bool keyCheck = false; //checks whether the button was held down last frame

	// Update is called once per frame
	void Update ()
	{
		float moveVertical = Input.GetAxisRaw ("Vertical") * interval;
		float moveHorizontal = Input.GetAxisRaw ("Horizontal") * interval;
		
		if (Input.anyKeyDown == true && keyCheck == false)
		{
			keyCheck = true;
			transform.Translate (moveHorizontal, moveVertical, 0);
		} 
		else
		{
			keyCheck = false;
		}
		
	}
}

