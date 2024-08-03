using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRandom : MonoBehaviour
{
    public float moveSpeed = 3f;        // Speed of the enemy
    public float changeDirectionTime = 2f; // Time between direction changes
    public float timeToChange = 1f; // Time tracker for changing direction

    private int direction = -1;          // Current direction (1 for right, -1 for left)

    void Update()
    {
        timeToChange -= Time.deltaTime;

        transform.Translate(Vector2.right * direction * moveSpeed * Time.deltaTime);

     if(timeToChange <= 0){

    direction = direction * -1;
    timeToChange = Random.Range(0.5f,1.5f);
     }
    }

    
}