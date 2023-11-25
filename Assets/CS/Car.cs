using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private Rigidbody2D frontTire; // 앞바퀴
    [SerializeField] private Rigidbody2D backTire; // 뒷바퀴
    [SerializeField] private Rigidbody2D car;
    
    [SerializeField] private float carSpeed = 150f; // 속도
    [SerializeField] private float rotationSpeed = 300f;

    private float moveInput;

    private void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        frontTire.AddTorque(-moveInput * carSpeed * Time.fixedDeltaTime);
        backTire.AddTorque(-moveInput * carSpeed * Time.fixedDeltaTime);
        car.AddTorque(moveInput * rotationSpeed * Time.fixedDeltaTime);
        
    }
}
