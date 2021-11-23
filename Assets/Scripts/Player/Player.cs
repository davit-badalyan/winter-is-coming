using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform snowballPoint;
    public Transform thrownSnoballs;
    public InputHandler inputHandler;
    public MovementHandler movementHandler;
    public Vector3 startPosition = new Vector3(0, 3, 0);


    public void ThrowSnowball()
    {
        GameObject snowball = snowballPoint.Find("PlayerSnowball").gameObject;
        snowball.transform.SetParent(thrownSnoballs.transform);

        snowball.AddComponent<Rigidbody>();
        snowball.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * 1000);

    }

    private void CheckForSnowball(GameObject newSnowball)
    {
        if (snowballPoint.Find("PlayerSnowball"))
        {
            return;
        }
        else
        {
            PickUpSnowball(newSnowball);
        }
    }

    private void PickUpSnowball(GameObject newSnowball)
    {
        newSnowball.name = "PlayerSnowball";
        newSnowball.transform.SetParent(snowballPoint);
        newSnowball.transform.position = snowballPoint.transform.position;
    }

    private void DrawRaycast()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.white);
    }

    private void Resume()
    {
        gameObject.transform.position = startPosition;
        gameObject.transform.rotation = Quaternion.identity;
    }

    private void Start()
    {
        Resume();
    }

    private void Update()
    {
        DrawRaycast();
    }
    private void LateUpdate()
    {
        movementHandler.Move(inputHandler.forwardMovement, inputHandler.sideMovement);
    }


    private void OnTriggerEnter(Collider other)
    {
        switch (other.transform.tag)
        {
            case "Snowball":
                CheckForSnowball(other.gameObject);
                break;
            default:
                break;
        }
    }
}
