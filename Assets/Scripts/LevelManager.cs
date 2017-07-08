using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name)
	{
		Debug.Log("level requested is loading " +name);
		Hits.brickCount = 0;
		Application.LoadLevel(name);
	}
	public void QuitLevel()
	{
		Debug.Log("I wanna Quit ");
		Application.Quit();
		
	}
	public void LoadNextLevel(){
			Hits.brickCount = 0;
			Application.LoadLevel(Application.loadedLevel + 1);
		
	}
	public void BrickDestroyed()
	{
		if(Hits.brickCount <=0)
		{
			LoadNextLevel();
		}
	
	}
	
}
