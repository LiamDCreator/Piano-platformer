using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class softplatformScript : MonoBehaviour
{
    private GameObject player;
   private Rigidbody2D rb;
    public string playerTag = "Player";
    

 
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag(playerTag);
    }

    void Update()
    {
        if (player != null)
        {
            Collider2D playerCollider = player.GetComponent<Collider2D>();
            Collider2D platformCollider = GetComponent<Collider2D>();

            // Ignore collision if the platform is above the player
            Physics2D.IgnoreCollision(platformCollider, playerCollider, transform.position.y > player.transform.position.y);
        }
        else
        {
            // Try to find the player again in case it's respawned or re-added to the scene
            player = GameObject.FindGameObjectWithTag(playerTag);
        }
    }
}