using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // AUDIO
    public AudioSource musicAudio;
    public AudioSource sfxAudio;
    public AudioClip backgroundMusic;
    public AudioClip explosionAudio;
    public AudioClip hitAudio;
    
    // UI
    public TMP_Text scoreText;
    
    // private vars
    private int score;
    private bool isGameOver;
    private int vidas;
    
    // props
    public int Score { get; set; }
    public int Vidas { get; set; }
    public bool IsGameOver { get; set; }
    
    
    // Start is called before the first frame update
    void Start()
    {
        // set text with score
        scoreText.text = "Score: "  + Score;
        
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void MakeScore(int points)
    {
        // updating score points
        Score += points;
        
        // set text with score
        scoreText.text = "Score: " + Score;
    }

    
    public void PlayAudio(AudioClip audio)
    {
        //play audio
        sfxAudio.PlayOneShot(audio);
    }
    
}
