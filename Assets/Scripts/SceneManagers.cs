using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    public string state;
    public GameObject panelGameOver;
    public GameObject panelGameComplete;
    public PlayerMovement playerMovement;
    void Start()
    {
        state = "ingame";        
        panelGameOver.SetActive(false);
        panelGameComplete.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(state.Equals("game over"))
        {
            playerMovement.onGameOver();
            panelGameOver.SetActive(true);
        }

        if(state.Equals("game complete"))
        {
            playerMovement.onGameOver();
            panelGameComplete.SetActive(true);
        }
        
    }

    public void setGameOver()
    {
        state = "game over";
    }

    public void setGameComplete()
    {
        state = "game complete";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // public void onGameComplete()
    // {

    // }
}
