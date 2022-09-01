using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public int score;
    public int additionalScore;
    public Text scoreText;
    public SceneManagers sceneManagers;
    private void Start() {
        score = 0;
        
    }

    private void Update() {
        scoreText.text = ""+ score;

        if(score >= 370)
        {
            sceneManagers.setGameComplete();
        }
    }

    public void AddScore()
    {
        score+=additionalScore;
    }
}