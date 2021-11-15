using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public Player player;

    public void Move(float forwardMovement, float sideMovement)
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(sideMovement, 0, forwardMovement).normalized * player.speed;

        rigidBody.velocity = movement;
        rigidBody.velocity = Vector3.ClampMagnitude(rigidBody.velocity, player.speed);
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
