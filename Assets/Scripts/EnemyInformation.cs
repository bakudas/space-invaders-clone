using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyInformation", menuName = "Enemy", order = 0)]
public class EnemyInformation : ScriptableObject
{
    
    public enum EnemyType
    {
        Inimigo01, Inimigo02, Inimigo03, Inimigo04
    }

    //public vars
    public EnemyType enemyType;
    // public Sprite enemySprite;
    public float speed;
    public int scorePoint;
    public GameObject bullet;
    public Color enemyColor;

}
