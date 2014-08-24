using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class SigintTrigger : MonoBehaviour {
	public List<SigintBase> triggerEffects;
	void OnTriggerEnter2D(Collider2D other) 
	{
		foreach(var triggerEffect in triggerEffects)
		{
			if(other.gameObject.GetComponent(triggerEffect.GetType()) == null)
			{
				var comp = other.gameObject.AddComponent(triggerEffect.GetType()) as SigintBase;
				comp.ModifyPlayer(other.GetComponent<Player>());
			}
		}
	}
}
