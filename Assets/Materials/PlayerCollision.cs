using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public PlayerMovement movement;
  private void OnCollisionEnter(Collision collisionInfo)
  {
    if (collisionInfo.collider.CompareTag("Obstacle"))
      movement.enabled = false;
    if(collisionInfo.collider.CompareTag("Ground"))
      Debug.Log("We hit the Ground!!");
  }
}
