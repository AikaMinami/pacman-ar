using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public EnemyController enemyController;
    public AudioSource introSong;
    public AudioSource chompSFX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(introSong.isPlaying);
        if(!introSong.isPlaying)
        {
            playerMovement.isGameStarted = true;
            enemyController.isMoved = true;
        }
    }

    public void playChompSFX()
    {
        chompSFX.Play();
    }
}
