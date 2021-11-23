using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public Player player;
    public float speed = 15.0f;
    public float rotationSpeed = 120.0f;

    public void Move(float forwardMovement, float sideMovement)
    {
        // Move rigidbody
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(sideMovement, 0, forwardMovement).normalized;

        rigidBody.velocity = movement * speed;
        rigidBody.velocity = Vector3.ClampMagnitude(rigidBody.velocity, speed);

        // Rotate to movement direction
        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            rigidBody.rotation = Quaternion.RotateTowards(rigidBody.rotation, toRotation, rotationSpeed * Time.deltaTime);
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
}
