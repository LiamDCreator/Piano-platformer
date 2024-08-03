using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
 public float shootSpeedWhistle1;
  
   

     public float shootCooldown;
      private float shootTimer;
      public GameObject bulletPrefabWhistle1;
  
    

    public Transform shootPoint; 
    public int whistleCount = 1; // whislte bullet the player is using. 3 types

    private Vector2 shootDirection = Vector2.right; // Default shooting direction

    
    void Update()
    {
           shootTimer -= Time.deltaTime;
        // Update the shoot direction based on movement keys
        if (Input.GetKeyDown(KeyCode.D))
        {
            shootDirection = Vector2.right;
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            shootDirection = Vector2.left;
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            shootDirection = Vector2.up;
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            shootDirection = Vector2.down;
        }

        // Check for shooting input
        if (Input.GetKeyDown(KeyCode.J) && shootTimer <= 0)
        {
            // Shoot in the determined direction
            shootBullet1(shootDirection);
            shootTimer = shootCooldown;
        }
        }

void shootBullet1(Vector2 direction){

    GameObject bullet = Instantiate(bulletPrefabWhistle1, shootPoint.position, Quaternion.identity);
       
       
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.velocity = shootDirection * shootSpeedWhistle1; 




        }
        }