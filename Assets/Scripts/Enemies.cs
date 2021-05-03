using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Enemies : MonoBehaviour
{

    // public vars
    public EnemyInformation enemy;

    // private vars
    private SpriteRenderer _spriteRenderer;
    private GameManager GM;
    
    
    private void Awake()
    {
        
        // get spriterenderer
        _spriteRenderer = GetComponent<SpriteRenderer>();
        
        // set color based enemy type
        _spriteRenderer.color = enemy.enemyColor;
        
        // get and set game manager
        GM = FindObjectOfType<GameManager>();

    }
    
    
    private void OnDestroy()
    {
        // score points
        GM.MakeScore(enemy.scorePoint);
        
        // play audio
        GM.PlayAudio(GM.explosionAudio);
    }
}


