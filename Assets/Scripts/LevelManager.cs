using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name)
	{
		Debug.Log("level requested is loading " +name);
		Application.LoadLevel(name);
	}
	public void QuitLevel()
	{
		Debug.Log("I wanna Quit ");
		Application.Quit();
		
	}
	
}
