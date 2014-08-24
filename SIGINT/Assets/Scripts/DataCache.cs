using UnityEngine;
using System.Collections;

public class DataCache : SigintBase {

	public string dataHint;
	public static int remainingCacheCnt;
	void Start () {
		DataCache.remainingCacheCnt = GameObject.FindGameObjectsWithTag("DataCache").Length;
	}
	void OnTriggerEnter2D(Collider2D other) 
	{
		var player = other.gameObject.GetComponent<Player>();
		if(player != null)
		{
			ModifyPlayer(player);
		}

	}

	public override void ModifyPlayer(Player player)
	{
		if(remainingCacheCnt == 1)
		{
			Application.LoadLevel(Application.loadedLevel + 1);
		}
		else
		{
			remainingCacheCnt-=1;
		}

	}
}
