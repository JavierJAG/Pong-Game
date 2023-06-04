using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject player1;
    public GameObject player1Goal;
    public GameObject player2;
    public GameObject player2Goal;

    public Text player1Text;
    public Text player2Text;

    private int player1Score;
    private int player2Score;

    public int maxScore = 10;


    public void checkVictory()
    {
        if (player1Score >= maxScore)
        {
            SceneManager.LoadScene("Player1Victory");
        }

        if (player2Score >= maxScore)
        {
            SceneManager.LoadScene("Player2Victory");
        }
    }
    public void Player1Scored()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        checkVictory();
        ResetPosition();
    }
    public void Player2Scored()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        checkVictory();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}

