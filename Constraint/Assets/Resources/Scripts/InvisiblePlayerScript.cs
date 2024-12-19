using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InvisiblePlayerScript : MonoBehaviour
{
    private ColliderControls controls;

    private Vector2 move;
    private void Awake()
    {
        controls = new ColliderControls();
        controls.ColliderGameplay.Move.performed += context => move = context.ReadValue<Vector2>();

        controls.ColliderGameplay.Move.canceled += context => move = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * 3f * Time.deltaTime;
        transform.Translate(m, Space.World);
    }
    
    private void OnEnable()
    {
        controls.ColliderGameplay.Enable();
    }

    private void OnDisable()
    {
        controls.ColliderGameplay.Disable();
        
    }
}
