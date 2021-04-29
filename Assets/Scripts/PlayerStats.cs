using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct PlayerStats
{
    // public vars 
    public float speedMovement;
    public int hitPoint;
    public float cooldown;
    public Rigidbody2D rb;
    public GameObject bullet;
    public Transform spawnbulletPoint;
    public AudioSource playerAudio;

    // private vars
    private float hInput;
    private float cooldownDefault;

    // proprieties
    public float HIpunt { get; set; }
    public float CooldownDefault { get; set; }
    
}
