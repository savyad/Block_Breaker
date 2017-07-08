using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Brick brick;
	private Vector3 brick2ball;
	private bool hasStarted= false;
	// Use this for initialization
	void Start () {
	brick= GameObject.FindObjectOfType<Brick>();
	brick2ball = this.transform.position - brick.transform.position;
	
	}
	
	
	// Update is called once per frame
	void Update () {
		if(!hasStarted){
			
			this.transform.position = brick.transform.position + brick2ball;
			if(Input.GetMouseButtonDown(0))
			{
				hasStarted=true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f,10f);
			
			}
		}
	
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		Vector2 tweak = new Vector2(Random.Range(0f,0.2f),Random.Range(0,0.2f));
		if(hasStarted){
				GetComponent<AudioSource>().Play();
				GetComponent<Rigidbody2D>().velocity +=tweak;
		}
	}
}
