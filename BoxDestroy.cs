using UnityEngine;
using System.Collections;
using UnityEngine.UI;//access to Text
public class BoxDestroy : MonoBehaviour {
	public int health=100;

	// Use this for initialization

	// Update is called once per frame

	void OnCollisionEnter(Collision col){
		Debug.Log ("I have collided with " + col.gameObject.name);

			Destroy(col.gameObject);
		health--;	
}
}
