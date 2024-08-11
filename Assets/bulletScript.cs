using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float bulletTimer;
    // Start is called before the first frame update
   void Update(){

    bulletTimer -= Time.deltaTime;
    if(bulletTimer <= 0){
        destroyBullet();
    }
   }
    void OnCollisionEnter2D(Collision2D collision){
 
    if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Structure")) 
        { 
       destroyBullet();
    }}

    private void destroyBullet(){

         Destroy(gameObject);
    }
}

