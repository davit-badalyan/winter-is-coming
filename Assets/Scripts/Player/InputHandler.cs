using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Player player;
    private float sideMovement;
    private float forwardMovement;

    private void CheckForInputs()
    {
        sideMovement = Input.GetAxisRaw("Horizontal");
        forwardMovement = Input.GetAxisRaw("Vertical");
    }

    private void Start()
    {
        //
    }

    private void Update()
    {
        CheckForInputs();
    }

    private void LateUpdate()
    {
        player.movementHandler.Move(forwardMovement, sideMovement);
    }
}
