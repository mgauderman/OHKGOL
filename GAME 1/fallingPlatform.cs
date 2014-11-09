using UnityEngine;
using System.Collections;

public class fallingPlatform : MonoBehaviour 
{
	void OnTriggerEnter(Collider col)
	{
		Debug.Log("I have collided with " + col.gameObject.name);
			rigidbody.useGravity = true;
			rigidbody.isKinematic = false;


	}
}