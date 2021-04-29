using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesBlock : MonoBehaviour
{
    // public vars
    public float speed;
    
    // private vars
    private bool isRight = true;
    private bool goDown = false;
    private float moveRange = 0.75f;

    
    private void Update()
    {

        Movement(); // move horizontaly
        MoveDown(); // move down when hit the boundaries

    }

    
    public void Movement()
    {
        // move the block
        if (isRight)
            transform.Translate(Vector2.right * (speed * Time.deltaTime));
        else
            transform.Translate(Vector2.right * (-speed * Time.deltaTime));

        // boundaries
        if (transform.position.x > moveRange)
        {
            isRight = false;
            goDown = true;
        }
        else if (transform.position.x < -moveRange)
        {
            isRight = true;
            goDown = true;
        }
    }

    
    public void MoveDown()
    {
        if (goDown)
        {
            // move the block down a bit
            transform.Translate(Vector2.down * 0.25f);
            
            // stop the movement to down
            goDown = false;
        }
    }
}
