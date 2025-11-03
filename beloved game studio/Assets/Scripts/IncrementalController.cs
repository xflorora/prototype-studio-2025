using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;

public class IncrementalController : MonoBehaviour
{
    public TMP_Text incrementalText;
    public double increments;
    public GameObject lineGenerator;
    public TMP_Text drawingText;
    public TMP_Text musicText;
    public TMP_Text randomText;
    public TMP_Text pongText;
    public Button lavaButton;
    public Button discoButton;
    public Button forestButton;

    /// <summary>
    /// THE PONG OBJECTS
    /// </summary>
    public GameObject ball;
    public GameObject player1Paddle;
    public GameObject player1Goal;
    public GameObject player2Paddle;
    public GameObject player2Goal;
    public GameObject topWall;
    public GameObject bottomWall;
    public GameObject Player1Text;
    public GameObject Player2Text;
    private int Player1Score;
    private int Player2Score;
    /// <summary>
    /// PONG OBJECTS
    /// </summary>
    

    public void Update()
    {
        incrementalText.text = "thanks for clicking! we now have " + increments + " moral support. can we get it to 1997 in honor of our next title release??";
    }

    public void GenerateSupport()
    {
        incrementalText.GameObject().SetActive(true);
        increments += 1;
        
        lineGenerator.SetActive(false);
        drawingText.GameObject().SetActive(false);
        
        musicText.GameObject().SetActive(false);
        lavaButton.gameObject.SetActive(false);
        discoButton.gameObject.SetActive(false);
        forestButton.gameObject.SetActive(false);
        
        randomText.GameObject().SetActive(false);
        
        pongText.GameObject().SetActive(false);
        ball.SetActive(false);
        player1Paddle.SetActive(false);
        player1Goal.SetActive(false);
        player2Paddle.SetActive(false);
        player2Goal.SetActive(false);
        topWall.SetActive(false);
        bottomWall.SetActive(false);
        Player1Text.GameObject().SetActive(false);
        Player2Text.GameObject().SetActive(false);
        ResetPosition();
    }
    
    public void LineOn()
    {
        lineGenerator.SetActive(true);
        drawingText.GameObject().SetActive(true);
        
        incrementalText.GameObject().SetActive(false);
        
        musicText.GameObject().SetActive(false);
        lavaButton.gameObject.SetActive(false);
        discoButton.gameObject.SetActive(false);
        forestButton.gameObject.SetActive(false);
        
        randomText.GameObject().SetActive(false);
        
        pongText.GameObject().SetActive(false);
        ball.SetActive(false);
        player1Paddle.SetActive(false);
        player1Goal.SetActive(false);
        player2Paddle.SetActive(false);
        player2Goal.SetActive(false);
        topWall.SetActive(false);
        bottomWall.SetActive(false);
        Player1Text.GameObject().SetActive(false);
        Player2Text.GameObject().SetActive(false);
        ResetPosition();
    }

    public void SoundOn()
    {
        musicText.GameObject().SetActive(true);
        lavaButton.gameObject.SetActive(true);
        discoButton.gameObject.SetActive(true);
        forestButton.gameObject.SetActive(true);
        
        incrementalText.GameObject().SetActive(false);
        
        lineGenerator.SetActive(false);
        drawingText.GameObject().SetActive(false);
        
        randomText.GameObject().SetActive(false);
        
        pongText.GameObject().SetActive(false);
        ball.SetActive(false);
        player1Paddle.SetActive(false);
        player1Goal.SetActive(false);
        player2Paddle.SetActive(false);
        player2Goal.SetActive(false);
        topWall.SetActive(false);
        bottomWall.SetActive(false);
        Player1Text.GameObject().SetActive(false);
        Player2Text.GameObject().SetActive(false);
        ResetPosition();
    }
    
    
    public void generateThoughts()
    {
        randomText.GameObject().SetActive(true);
        
        incrementalText.GameObject().SetActive(false);
        
        lineGenerator.SetActive(false);
        drawingText.GameObject().SetActive(false);
        
        musicText.GameObject().SetActive(false);
        lavaButton.gameObject.SetActive(false);
        discoButton.gameObject.SetActive(false);
        forestButton.gameObject.SetActive(false);
        
        pongText.GameObject().SetActive(false);
        ball.SetActive(false);
        player1Paddle.SetActive(false);
        player1Goal.SetActive(false);
        player2Paddle.SetActive(false);
        player2Goal.SetActive(false);
        topWall.SetActive(false);
        bottomWall.SetActive(false);
        Player1Text.GameObject().SetActive(false);
        Player2Text.GameObject().SetActive(false);
        ResetPosition();
    }

    public void pongOn()
    {
        pongText.GameObject().SetActive(true);
        ball.SetActive(true);
        player1Paddle.SetActive(true);
        player1Goal.SetActive(true);
        player2Paddle.SetActive(true);
        player2Goal.SetActive(true);
        topWall.SetActive(true);
        bottomWall.SetActive(true);
        Player1Text.GameObject().SetActive(true);
        Player2Text.GameObject().SetActive(true);
        
        incrementalText.GameObject().SetActive(false);
        
        lineGenerator.SetActive(false);
        drawingText.GameObject().SetActive(false);
        
        musicText.GameObject().SetActive(false);
        lavaButton.gameObject.SetActive(false);
        discoButton.gameObject.SetActive(false);
        forestButton.gameObject.SetActive(false);
        
        randomText.GameObject().SetActive(false);
        
    }

    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}
