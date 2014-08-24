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
		if (this.leftKey != "" && Input.GetKey (this.leftKey)) {
			gameObject.transform.Translate (Vector3.left * this.speed);
		} else if (this.rightKey != ""  && Input.GetKey (this.rightKey)) {
			gameObject.transform.Translate (Vector3.right * this.speed);
		} else {
			this.speed = 0;
		}
	}
	
//	void OnTriggerEnter(Collider other) {
//		switch(other.name)
//		{
//		case "RightDisable":
//			Destroy(other.gameObject);
//			this.rightMoveEnabled = false;
//			break;
//		case "RightReenabled":
//			if(!this.rightMoveEnabled) {
//				Destroy(other.gameObject);
//				this.rightMoveEnabled = true;
//			}
//			break;
//		default:
//			break;
//		}
//	}
}
