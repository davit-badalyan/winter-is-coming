using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Player player;
    public float sideMovement;
    public float forwardMovement;

    private void CheckForMovement()
    {
        sideMovement = Input.GetAxisRaw("Horizontal");
        forwardMovement = Input.GetAxisRaw("Vertical");
    }

    private void CheckForSnowballThrowing()
    {
        bool spacePressed = Input.GetKeyDown(KeyCode.Space);
        bool snowball = player.snowballPoint.Find("PlayerSnowball");

        if (spacePressed && snowball)
        {
            player.ThrowSnowball();
        }
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
}
