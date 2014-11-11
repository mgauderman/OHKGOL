using UnityEngine;
using System.Collections;

public class fallingPlatform : MonoBehaviour {
	
	 void Start(){

		}
	void OnTriggerEnter(Collider col){
		Debug.Log ("I have collided with " + col.gameObject.name);
		rigidbody.useGravity = true;
		rigidbody.isKinematic = false;
		if (col.gameObject.tag == "terrain") {
			Vector3 temp = new Vector3(0,147.0f,0);
			transform.position += temp;
			Debug.Log ("YESSS " + col.gameObject.name);
			rigidbody.useGravity=false;
			rigidbody.isKinematic=true;
			
		}
	}
}
