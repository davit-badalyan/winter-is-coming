using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public Player player;
    public float speed = 15.0f;
    public float rotationSpeed = 120.0f;
    public VariableJoystick variableJoystick;

    public void Move()
    {
        // Move rigidbody
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;


        rigidBody.velocity = direction * speed;
        rigidBody.velocity = Vector3.ClampMagnitude(rigidBody.velocity, speed);

        // Rotate to movement direction
        if (direction != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);
            rigidBody.rotation = Quaternion.RotateTowards(rigidBody.rotation, toRotation, rotationSpeed);
        }
    }

    private void Start()
    {
        //
    }

    private void Update()
    {
        //
    }

    private void FixedUpdate()
    {
        Move();
    }
}
