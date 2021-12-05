using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Player player;

    public void CheckForSnowballThrowing()
    {
        bool snowball = player.snowballPoint.Find("PlayerSnowball");
        if (snowball) player.ThrowSnowball();
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
