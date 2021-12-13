using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform detectArea;
    public Transform snowballPoint;
    public Transform thrownSnoballs;
    public InputHandler inputHandler;
    public MovementHandler movementHandler;
    public Vector3 startPosition = new Vector3(0, 3, 0);


    public void ThrowSnowball()
    {
        float force = 1000;
        float forceMultiplier = 100;
        float radius = detectArea.transform.localScale.x / 2;

        Vector3 direction = Vector3.forward * force;
        GameObject snowball = snowballPoint.Find("PlayerSnowball").gameObject;
        Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, radius);

        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.tag == "Enemy")
            {
                Vector3 relativePos = hitCollider.transform.position - gameObject.transform.position;
                Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);

                float distacneBetween = Vector3.Distance(hitCollider.transform.position, gameObject.transform.position);
                force = distacneBetween * forceMultiplier;
                direction = new Vector3(0, 0, force);

                transform.rotation = rotation;
            }
        }

        snowball.transform.SetParent(thrownSnoballs.transform);
        snowball.AddComponent<Rigidbody>();
        snowball.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(direction));

    }

    private void CheckForSnowball(GameObject newSnowball)
    {
        Transform snowball = snowballPoint.Find("PlayerSnowball");

        if (!snowball) PickUpSnowball(newSnowball);
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

    private void OnTriggerEnter(Collider other)
    {
        string tag = other.transform.tag;
        GameObject gameObject = other.gameObject;

        switch (tag)
        {
            case "Snowball":
                CheckForSnowball(gameObject);
                break;
            default:
                break;
        }
    }
}
