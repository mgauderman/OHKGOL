using UnityEngine;
using System.Collections;

public class sceneNav : MonoBehaviour {

	[SerializeField] private string level = "";                                       
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "First Person Character") 
		{
			Application.LoadLevel(level);
		}
	}
}
