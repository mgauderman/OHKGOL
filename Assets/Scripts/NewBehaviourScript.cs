using UnityEngine;
using System.Collections;
using UnityEngine.UI;//access to Text
public class NewBehaviourScript : MonoBehaviour {
	public int health=100;

	[SerializeField] //see in unity editor	
	private GameObject Skeleton;
	// Use this for initialization
	public Text HealthText;
	//
	void Start () {
		Debug.Log ("Starting " + this.name);
		//Skeleton = GameObject.FindGameObjectWithTag ("Evil Skeleton"); (you can drag and drop GameObject

		HealthText.text = "Health: " + health;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Updating " + this.name);

	}
	//void OnTriggerEnter(Collider collider){
	//if (collider.gameObject.tag == "Enemy") {
	//Destroy (collider.gameObject);

	//void On
	void OnCollisonEnter(Collision collision){
		Debug.Log ("I have collided with " + collision.gameObject.name);
		health -= 10;
		if (collision.gameObject.tag == "Enemy") {
						Destroy (collision.gameObject);
				

		//find me a skeleton (var)
		//GameObject skeleton = GameObject.FindGameObjectWithTag ("EvilSkeleton");
		//if (skeleton!=null)
		//Destroy (skeleton);

			Instantiate (Skeleton, this.gameObject.transform.position, gameObject.transform.rotation);
		}
}
}
