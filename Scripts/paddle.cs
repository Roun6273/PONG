using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//paddle.cs is the background script for both player and computer paddle 
public class paddle : MonoBehaviour
{
    public float PaddleSpeed = 40.0f;

    protected Rigidbody2D _rigidbody;

    private void Awake(){
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
