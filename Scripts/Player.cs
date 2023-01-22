using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player.cs is the script handling all reactions for the player pong paddle
public class Player : paddle
{
    private Vector2 _direction;
  
    private void Update(){
        //as per Dr. BC Guideline for
        if(Input.GetKey("escape")){
            Application.Quit();
        } 
        else{
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
                _direction = Vector2.up;
            }
            else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
                _direction = Vector2.down;
            }
            else{
                _direction = Vector2.zero;
            }

        }
            
        
    }

    private void FixedUpdate(){
        if(_direction.sqrMagnitude != 0){
            _rigidbody.AddForce(_direction * this.PaddleSpeed);
        }
    }
}
