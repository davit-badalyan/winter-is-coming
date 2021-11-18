using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15.0f;
    public InputHandler inputHandler;
    public MovementHandler movementHandler;
    public Vector3 startPosition = new Vector3(0, 3, 0);

    public GameObject snowball { get; private set; }

    private void Resume()
    {
        gameObject.transform.position = startPosition;
        gameObject.transform.rotation = Quaternion.identity;
    }

    private void CheckForSnowball(GameObject newSnowball)
    {
        if (snowball)
        {
            return;
        } else
        {
            PickUpSnowball(newSnowball);
        }
    }

    private void PickUpSnowball(GameObject newSnowball)
    {
        string newParentObjectName = "SnowballPoint";
        string newParentLocation = "/" + gameObject.name + "/" + newParentObjectName;
        GameObject nweParentObject = GameObject.Find(newParentLocation);

        snowball = newSnowball;
        newSnowball.transform.SetParent(nweParentObject.transform);
        newSnowball.transform.position = nweParentObject.transform.position;
    }

    private  void Start()
    {
        Resume();
    }

    private void Update()
    {
        //
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
