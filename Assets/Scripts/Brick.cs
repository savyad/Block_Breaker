using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public bool autoplay=false;
	private Ball ball;
	// Use this for initialization
	void Start () {
		ball=GameObject.FindObjectOfType<Ball>();
		print(ball);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!autoplay){
		MoveWithMouse();
		}
		else{
			Autoplay();
		
		}	
	}
	void Autoplay(){
		Vector3 paddPos = new Vector3(0.5f,this.transform.position.y,0f); 
		Vector3 ballpos = ball.transform.position;
		paddPos.x = Mathf.Clamp(ballpos.x, 0.5f, 15.5f);
		this.transform.position = paddPos;
	
	
	
	}
	
	
	
	void MoveWithMouse()
	{
		Vector3 paddPos = new Vector3(0.5f,this.transform.position.y,0f); 
		float var = Input.mousePosition.x / Screen.width * 16;
		paddPos.x = Mathf.Clamp(var, 0.5f, 15.5f);
		this.transform.position = paddPos;
		
	}
}
