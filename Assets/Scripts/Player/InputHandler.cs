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
        if (Input.GetKeyDown(KeyCode.Space) && player.snowballPoint.Find("PlayerSnowball"))
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
