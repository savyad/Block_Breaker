using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;

	// Use this for initialization
	void awake()
	{
		Debug.Log("Music player has been awaken " + GetInstanceID());
	
	}
	void Start () {
		Debug.Log("Music player started " + GetInstanceID());
		if(instance !=null)
		{
			Destroy (gameObject);
			print("Duplicate music player destroyed");
		}
		else{
			instance = this;
				GameObject.DontDestroyOnLoad(gameObject);
		}
		 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
