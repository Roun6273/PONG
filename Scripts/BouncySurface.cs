using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//BouncySurface.cs is a material behavior script to help with adding additional speed 
//and difficulty to pong ball as game goes on
public class BouncySurface : MonoBehaviour
{
  public float bounceStr;   //holds strength value of how hard the bounce can occur

  private void OnCollisionEnter2D(Collision2D collision){
    PongBall ball = collision.gameObject.GetComponent<PongBall>();

    if(ball != null){
        Vector2 normal = collision.GetContact(0).normal;
        ball.AddForce(-normal * bounceStr);
    }
  }
}
