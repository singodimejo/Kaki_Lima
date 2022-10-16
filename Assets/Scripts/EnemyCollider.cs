using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyCollider : MonoBehaviour
{
    public PlayerMovement playerMove;
    public AIPath ai;

    

    // Update is called once per frame
    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            playerMove.enabled = false;
            ai.canMove = false;
        }
    }
}
