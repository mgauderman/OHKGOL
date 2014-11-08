using UnityEngine;
using System.Collections;
using UnityEngine.UI;//access to Text
public class BoxDestroy : MonoBehaviour {
	public int health=100;

	// Use this for initialization

	// Update is called once per frame

	void OnCollisonEnter(Collision collision){
		Debug.Log ("I have collided with " + collision.gameObject.name);

			Destroy (collision.gameObject);
		health--;
}
}
