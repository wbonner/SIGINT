using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float velocity;
	public float speed;
	public float maxSpeed;
	
	private string leftKey;
	private string rightKey;
	
	private bool leftMoveEnabled;
	private bool rightMoveEnabled;
	
	// Use this for initialization
	void Start () {
		this.leftKey = "a";
		this.rightKey = "d";
		
		this.leftMoveEnabled = true;
		this.rightMoveEnabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		//Update movement
		if (Input.GetKey (this.leftKey) || Input.GetKey (this.rightKey)) {
			this.speed += this.velocity;
			if(this.speed > this.maxSpeed) this.speed = this.maxSpeed;
		}
		
		if (Input.GetKey (this.leftKey) && this.leftMoveEnabled) {
			gameObject.transform.Translate (Vector3.left * this.speed);
		} else if (Input.GetKey (this.rightKey) && this.rightMoveEnabled) {
			gameObject.transform.Translate (Vector3.right * this.speed);
		} else {
			this.speed = 0;
		}
	}
	
	void OnTriggerEnter(Collider other) {
		switch(other.name)
		{
		case "RightDisable":
			Destroy(other.gameObject);
			this.rightMoveEnabled = false;
			break;
		case "RightReenabled":
			if(!this.rightMoveEnabled) {
				Destroy(other.gameObject);
				this.rightMoveEnabled = true;
			}
			break;
		default:
			break;
		}
	}
}
