﻿//( ͡° ͜ʖ ͡°)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D _rgb2d;
    [SerializeField]private float _moveSpeed;

	void Start () {
        _rgb2d = GetComponent<Rigidbody2D>();
        ControllerInput.MovementInput += Move;
	}

    void Move(Vector2 moveDir)
    {
        _rgb2d.MovePosition(_rgb2d.position + moveDir * _moveSpeed * Time.deltaTime);
    }
}
