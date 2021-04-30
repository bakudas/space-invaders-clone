using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesBlock : MonoBehaviour
{
    // public vars
    public float speed;
    public GameObject enemy;
    public int enemiesRows, enemiesColumn;
    public Vector2 initialSpawnPos = new Vector2(-7.5f, 2.5f);
    public Vector2 offset = Vector2.right;
    
    // private vars
    private bool isRight = true;
    private bool goDown = false;
    private float moveRange = 0.75f;
    private GameObject[] enemies;

    private void Start()
    {
        // inicializa o array de inimigos
        enemies = new GameObject[enemiesRows * enemiesColumn];
        
        // cria os inimigos da fase com base na quantidade de colunas e linhas definidas no editor
        CreateEnemies(enemiesRows, enemiesColumn);
    }

    private void CreateEnemies(int rows, int column)
    {
        var spawnPos = initialSpawnPos;

        if (enemies != null)
        {
            // percorre as linhas
            for (int r = 0; r < rows; r++)
            {
                // percorre as colunas
                for (int c = 0; c < column; c++)
                {
                    // instancia o inimigo e coloca no array
                    enemies[c] = Instantiate(enemy, spawnPos + offset, Quaternion.identity);
                    
                    // adiciona os inimigos ao bloco como parent
                    enemies[c].transform.parent = transform;
                    
                    // renomea os inimigos
                    enemies[c].name = "Inimigo0" + (r + 1);
                    
                    // renova a posição do próximo spawner
                    spawnPos = enemies[c].transform.position;
                    
                }
            
                // desce o spawner para a próxima linha
                spawnPos = initialSpawnPos - new Vector2(0, r);

            }
        }

    }
    
    
    private void Update()
    {

        Movement(); // move horizontaly
        MoveDown(); // move down when hit the boundaries

    }

    
    public void Movement()
    {
        // move the block
        if (isRight)
        {
            transform.Translate(Vector2.right * (speed * Time.deltaTime));
        }
            
        else
        {
            transform.Translate(Vector2.right * (-speed * Time.deltaTime));
        }
            

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
