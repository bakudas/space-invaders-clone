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
    
    private void Awake()
    {
        
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.color = enemy.enemyColor;
        

    }
}


