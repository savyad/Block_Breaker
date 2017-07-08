using UnityEngine;
using System.Collections;

public class DhillaCollider : MonoBehaviour {

	// Use this for initialization
	public LevelManager levelmanager;
	void start(){
		levelmanager=GameObject.FindObjectOfType<LevelManager>();
	
	}
	
	void OnTriggerEnter2D(Collider2D trigger) {
		print("Trigger");
		levelmanager.LoadLevel("Loose");
		
	}
	
}
