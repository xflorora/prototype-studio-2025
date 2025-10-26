using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    
    public int score = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateScoreText();
    }
    void UpdateScoreText()
    {
        //updating the actual score to the score shown on the text canvas
        scoreText.text = "score: " + score.ToString();
        PlayerPrefs.SetString("score", scoreText.text);
    }
    
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }
}
