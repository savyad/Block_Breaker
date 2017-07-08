using UnityEngine;
using System.Collections;

public class Hits : MonoBehaviour {
	private LevelManager levelmanager;
	private int timesHit;
	private bool isBreakable;
	
	
	public Sprite[] hitSprites;
	public  static int brickCount = 0;
	public AudioClip crack;
	public GameObject smoke;
	public GameObject smokepuff;
	// Use this for initialization
	void Start () {
		isBreakable=(this.tag =="breakable");
		if(isBreakable)
		{
			brickCount++;
			print(brickCount);
		}
		timesHit=0;
		levelmanager=GameObject.FindObjectOfType<LevelManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col)
	{
	 	AudioSource.PlayClipAtPoint(crack,transform.position);
		if(isBreakable){
			Handlehits();
		}
		
	}
	 void Handlehits(){
	 
		timesHit++;
		int maxHit = hitSprites.Length + 1;
		if(timesHit >= maxHit )
		{
			brickCount--;
			levelmanager.BrickDestroyed();	
			smokepuff=Instantiate (smoke,transform.position,Quaternion.identity) as GameObject;
			smokepuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
			Destroy(gameObject);
		}
		else{
			LoadSprites();
		}
		
	 
	 
	 }
	 
	 
	void LoadSprites()
	{
		int spriteIndex = timesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite = hitSprites	[spriteIndex];
	
	}
	
	void simulateWin(){
		levelmanager.LoadNextLevel();
	}
	
}
