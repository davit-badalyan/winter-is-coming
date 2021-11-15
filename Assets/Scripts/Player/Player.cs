using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public InputHandler inputHandler;
    public MovementHandler movementHandler;
    public Vector3 startPosition = new Vector3(0, 3, 0);

    private void Resume()
    {
        gameObject.transform.position = startPosition;
        gameObject.transform.rotation = Quaternion.identity;
    }

    private  void Start()
    {
        Resume();
    }

    private void Update()
    {
        //
    }
}
