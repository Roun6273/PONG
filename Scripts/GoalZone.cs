using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//GoalZone.cs is the scrit that handles the 
//actual area of goal on left and right walls behind
//each of the player and comp paddle
public class GoalZone : MonoBehaviour
{
    //score trigger
  public EventTrigger.TriggerEvent scoreTrigger;

  private void OnCollisionEnter2D(Collision2D collision){
    PongBall ball = collision.gameObject.GetComponent<PongBall>();

    //if ball collides with goal zone, this will trigger the goal to be tallied 
    //using the EventSystems library
    if(ball != null){
        BaseEventData eventData = new BaseEventData(EventSystem.current);
        this.scoreTrigger.Invoke(eventData);
    }
  }
}
