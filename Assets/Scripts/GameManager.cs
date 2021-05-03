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
        scoreText.text = "teste$$$";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
