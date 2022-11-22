using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Base_CC_Move : MonoBehaviour
{
    public float Gravity = 9.81f;
    public float JumpPower = 3f;
    public float Speed = 4f;

    private CharacterController controller;
    private Joystick joystick;
    private joystickButton joystickbutton;
    private Vector3 movement;

    // Use this for initialization

    private void Start()
    {
        //getting the CC and joysticks
        controller = GetComponent<CharacterController>();
        joystick = FindObjectOfType<Joystick>();
        joystickbutton = FindObjectOfType<joystickButton>();
    }

    private void Update()
    {
        //setting the movement direction from the joystick
        movement.x = joystick.Horizontal;
        movement.z = joystick.Vertical;

        if (controller.isGrounded)
        {
            movement.y = 0; // if we are grounded, we reset the downwards movement

            if (joystickbutton.pressed)
            {
                joystickbutton.pressed = false; // if the joystick button is pressed we reset it and then add the jump
                movement.y += JumpPower;
            }
        }
        else
        {
            movement.y -= Gravity * Time.deltaTime; // if we are not gounded, we add gravity 
        }

        //lastly we do the movement with our speed
        controller.Move(movement * Speed * Time.deltaTime);
    }
}