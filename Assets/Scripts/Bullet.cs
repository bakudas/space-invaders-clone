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
    public GameObject bulletFX;
    
    private void Update()
    {
        // move the bullet up 
        transform.Translate(Vector2.up * (bulletSpeed * Time.deltaTime));

        //  destroy bullet outside the bounds
        if (transform.position.y > boundUp) Destroy(gameObject);
    }
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Enemies"))
        {
            
            // destroy enemies
            Destroy(other.gameObject);
            
            // destroy bullet
            Destroy(gameObject);
            
            // spawn the bullet hit fx
            Instantiate(bulletFX, transform.position, Quaternion.identity);
            
        }
    }
}
