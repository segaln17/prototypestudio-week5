using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    private PlayerControls controls;
    // Start is called before the first frame update

    private Vector2 move;
    //private Vector2 rightMove;
    
    private void Awake()
    {
        //creating controls as something we can refer to anytime we want to do something with player controls
        controls = new PlayerControls();

        controls.Gameplay.Move.performed += context => move = context.ReadValue<Vector2>();
        //controls.Gameplay.Grow.performed += context => Grow();
        //controls.Gameplay.Shrink.performed += context => Shrink();
        
        //disable when not moving joystick
        controls.Gameplay.Move.canceled += context => move = Vector2.zero;
    }

    private void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * 5f * Time.deltaTime;
        transform.Translate(m, Space.World);
    }

    void Grow()
    {
        transform.localScale *= 1.1f;
    }

    void Shrink()
    {
        transform.localScale *= 0.5f;
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
        
    }
}
