using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType
{
    Inimigo01, Inimigo02, Inimigo03, Inimigo04
}

[Serializable]
public struct EnemiesStats
{
    
    //public vars
    public EnemyType enemyType;
    public float speed;
    public GameObject bullet;
    
    // private vars
    private Color enemieColor;
    
}

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Enemies : MonoBehaviour
{
    public EnemiesStats enemy;



    public void Disable()
    {
        gameObject.SetActive(false);
    }

}


