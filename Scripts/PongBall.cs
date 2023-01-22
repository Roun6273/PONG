using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//PongBall.cs is the  behavior script for the ball and interactions done to the ball.
public class PongBall : MonoBehaviour{

    public float Ballspeed = 1000.0f;
    private Rigidbody2D _rigidbody;

    //assigns object compoents
    private void Awake(){
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    //Starts game
    private void Start(){
        ResetBall();
    }
    //reset ball after score
    public void ResetBall(){
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;

        //calls out function to restart pong ball
        AddStartingForce();
    }
    
    //determines angle at which ball will move at start of game
    private void AddStartingForce(){
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.Ballspeed);
                                        
    }

    //adds initial force to the pong ball
    public void AddForce(Vector2 force){
        _rigidbody.AddForce(force);
    }

    
}
