using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Computer.cs is the script handling the AI movement of the computer pong Paddle
public class Computer : paddle
{
    public Rigidbody2D ball;
    
    private void FixedUpdate(){
        if(this.ball.velocity.x > 0.0f){
            if(this.ball.position.y > this.transform.position.y){
                _rigidbody.AddForce(Vector2.up * this.PaddleSpeed);
            }
            else if(this.ball.position.y < this.transform.position.y){
                _rigidbody.AddForce(Vector2.down * this.PaddleSpeed);
            }
        }
        else{
            if(this.transform.position.y > 0.0f){
                _rigidbody.AddForce(Vector2.down * this.PaddleSpeed);
            }
            else if(this.transform.position.y < 0.0f){
                _rigidbody.AddForce(Vector2.up * this.PaddleSpeed);
            }
        }
    }
}
