using System;
using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
 public int playerScore = 0; // Player's score
    public Text scoreText;
    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd; // Increment the score by 1
        UpdateScoreText(); // Update the score display
    }

    
    private void UpdateScoreText()
    {
        scoreText.text = playerScore.ToString();// Update the UI text element with the current score
    }
}
