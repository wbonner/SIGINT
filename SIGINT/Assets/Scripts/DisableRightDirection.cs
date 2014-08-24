using UnityEngine;
using System.Collections;

public class DisableRightDirection : SigintBase 
{
	private Player playerHandle;
	private string oldRightKey;
	public override void ModifyPlayer(Player player)
	{
		oldRightKey = player.rightKey;
		playerHandle = player;
		player.rightKey = "";

	}
	public void OnDestroy()
	{
		playerHandle.rightKey = oldRightKey;

	}
}
