using UnityEngine;
using System.Collections;

public class teleporterMove : MonoBehaviour {
	[SerializeField] private float x = 0;                                       
	[SerializeField] private float y = 0;                                    
	[SerializeField] private float z = 0;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "First Person Character") 
		{
			col.gameObject.transform.position = new Vector3(x, y, z);
		}
	}
}
