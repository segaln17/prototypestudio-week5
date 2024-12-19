using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AltInvisiblePlayer : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 6f;

    private Vector3 invisibleInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        invisibleInput = new Vector3(Input.GetAxisRaw("RHorizontal"), 0, Input.GetAxisRaw("RVertical")).normalized;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + invisibleInput * Time.deltaTime * speed);
    }
}
