using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatObject : MonoBehaviour
{
    public ScoreManager scoreManager;
    public SoundManager soundManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            soundManager.playChompSFX();
            scoreManager.AddScore();
            Destroy(this.gameObject);
        }
    }
}
