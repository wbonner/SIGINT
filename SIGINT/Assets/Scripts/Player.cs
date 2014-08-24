using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {
	
	public float velocity;
	public float speed;
	public float maxSpeed;

	public string leftKey;
	public string farLeftKey;
	public string rightKey;
	public string farRightKey;


	// Update is called once per frame
	void Update () {
		//Update movement
		if (leftKey != "" && Input.GetKey (this.leftKey) || 
		   rightKey != "" && Input.GetKey (this.rightKey))
		{
			this.speed += this.velocity;
			if(this.speed > this.maxSpeed) this.speed = this.maxSpeed;
		}
		if (farLeftKey != "" && Input.GetKey (this.farLeftKey) || 
		    farRightKey != "" && Input.GetKey (this.farRightKey))
		{
			this.speed += this.velocity * 2;
			if(this.speed > this.maxSpeed) this.speed = this.maxSpeed;
		}
		
		if (this.leftKey != "" && Input.GetKey (this.leftKey)) {
			gameObject.transform.Translate (Vector3.left * this.speed);
		} else if (this.rightKey != ""  && Input.GetKey (this.rightKey)) {
			gameObject.transform.Translate (Vector3.right * this.speed);
		} else if (this.farRightKey != ""  && Input.GetKey (this.farRightKey)) {
			gameObject.transform.Translate (Vector3.right * this.speed);
		} else if (this.farLeftKey != ""  && Input.GetKey (this.farLeftKey)) {
			gameObject.transform.Translate (Vector3.left * this.speed);
		} else {
			this.speed = 0;
		}
	}
}
