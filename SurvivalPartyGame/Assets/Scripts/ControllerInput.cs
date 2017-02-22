using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour {

    public delegate void InputDelegate();
    public delegate void MovementDelegate();
    public static event MovementDelegate MovementInput;
    public static event InputDelegate AttackInput;

    void Update()
    {
        if (Input.GetButtonDown(InputAxes.XBOX_X) && AttackInput != null)
        {
            AttackInput();
        }

        if (MovementInput != null)
        {
            MovementInput();
        }
    }
}
