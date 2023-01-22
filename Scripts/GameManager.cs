using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//GameManager.cs is the script handling the scoreing and reset positions
public class GameManager : MonoBehaviour
{
  public PongBall ball;         //calls pong ball object
  private int _playerScore;     //keeping track of player score
  private int _computerScore;    //keeping track of computer score  
  public Text playerScoreText;      //UI text to be displayed for player score
  public Text compScoreText;        //UI text to be displayed for the comp score


    //increments player score
  public void PlayerScore(){
        _playerScore++;

        Debug.Log(_playerScore);        //debug printout to make sure working
        this.playerScoreText.text = _playerScore.ToString();
        this.ball.ResetBall();
    
  }
    //increments computer score
  public void CompScore(){
        _computerScore++;

        Debug.Log(_computerScore);      //debug printout to make sure working  
        this.compScoreText.text = _computerScore.ToString();
        this.ball.ResetBall();
  }

}
