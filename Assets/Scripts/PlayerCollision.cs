using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

	public PlayerMovement movement;
	private void OnCollisionEnter(Collision collisionInfo)
	{
		// When player hits an obstacle the movement of the player is turned off
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;
		}
	}

}
