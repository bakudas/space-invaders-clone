using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Bullet : MonoBehaviour
{

    // public vars
    public float bulletSpeed;
    public float boundUp = 5.5f;

    
    private void Update()
    {
        // move the bullet up 
        transform.Translate(Vector2.up * (bulletSpeed * Time.deltaTime));

        //  destroy bullet outside the bounds
        if (transform.position.y > boundUp) Destroy(gameObject);
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemies"))
        {
            // destroy enemies
            Destroy(other.gameObject);
            
            // destroy bullet
            Destroy(gameObject);
        }
    }
}
