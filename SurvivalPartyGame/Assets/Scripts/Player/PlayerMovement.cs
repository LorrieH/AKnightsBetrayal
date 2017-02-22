using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D _rgb2d;
    [SerializeField]private float _moveSpeed;

	void Start () {
        _rgb2d = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxis("Left_JoystickX_P1");
        float y = Input.GetAxis("Left_JoystickY_P1");
        _rgb2d.velocity = new Vector2(x * _moveSpeed, y * _moveSpeed);
    }
}
