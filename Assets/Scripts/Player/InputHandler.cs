using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Player player;
    private float sideMovement;
    private float forwardMovement;

    private void CheckForMovement()
    {
        sideMovement = Input.GetAxisRaw("Horizontal");
        forwardMovement = Input.GetAxisRaw("Vertical");
    }

    private void CheckForSnowballThrowing()
    {
        if (Input.GetKeyDown(KeyCode.Space) && player.snowball)
        {
            ThrowSnowball();
        }
    }

    private void ThrowSnowball()
    {
        // ToDo 
        // Implement snowball throwing
        Destroy(player.snowball);
    }

    private void Start()
    {
        //
    }

    private void Update()
    {
        CheckForMovement();
        CheckForSnowballThrowing();
    }

    private void LateUpdate()
    {
        player.movementHandler.Move(forwardMovement, sideMovement);
    }
}
