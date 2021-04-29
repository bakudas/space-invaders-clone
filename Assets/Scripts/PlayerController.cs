using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{
    
    public PlayerStats PlayerStats;
    
    private void Start()
    {
        // get rigidbody and set to rb var
        PlayerStats.rb = GetComponent<Rigidbody2D>();
        
        // set defeault cooldown
        PlayerStats.CooldownDefault = PlayerStats.cooldown;
    }
    
    // Update is called once per frame
    void Update()
    {
        // get the player's input
        PlayerStats.HIpunt = Input.GetAxis("Horizontal");
        
        // move the player
        PlayerMovement(PlayerStats.HIpunt, PlayerStats.speedMovement);
        
        // shooooot madefoca
        PlayerStats.cooldown -= Time.deltaTime;
        var shootButton = Input.GetKey(KeyCode.Space);
        if ( shootButton && PlayerStats.cooldown < 0 ) PlayerShoot();

        // reposition the player
        if (transform.position.y < -4f)
        {
            transform.position = new  Vector2(transform.position.x, -4);
        }
        
    }

    private void PlayerMovement(float input, float speed)
    {
        // move player 
        transform.Translate(Vector3.right * (speed * input * Time.deltaTime));
    }

    private void PlayerShoot()
    {
        // make an instance of the bullet object
        Instantiate(PlayerStats.bullet, PlayerStats.spawnbulletPoint.position, PlayerStats.bullet.transform.rotation);
        
        // set the default cooldown
        PlayerStats.cooldown = PlayerStats.CooldownDefault;
    }
}
