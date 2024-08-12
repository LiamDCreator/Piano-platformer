using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTowardsPlayer : MonoBehaviour
{
    public Transform target;
    public float speed;
    
    void Update()
    {
        var movespeed = speed * Time.deltaTime;
         transform.position = Vector3.MoveTowards(transform.position, target.position, movespeed);
    }

     void OnCollisionEnter2D(Collision2D collision){
 
    if (collision.gameObject.CompareTag("Bullet")) 
        { 
         Destroy(gameObject);
    }}
}
