using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public bool hasSnowball = false;
    public InputHandler inputHandler;
    public MovementHandler movementHandler;
    public Vector3 startPosition = new Vector3(0, 3, 0);

    private void Resume()
    {
        gameObject.transform.position = startPosition;
        gameObject.transform.rotation = Quaternion.identity;
    }

    private void CheckForSnowball(GameObject snowball)
    {
        if (hasSnowball)
        {
            return;
        } else
        {
            PickUpSnowball(snowball);
        }
    }

    private void PickUpSnowball(GameObject snowball)
    {
        hasSnowball = true;

        string newParentObjectName = "SnowballPoint";
        string newParentLocation = "/" + gameObject.name + "/" + newParentObjectName;
        GameObject nweParentObject = GameObject.Find(newParentLocation);

        snowball.transform.SetParent(nweParentObject.transform);
        snowball.transform.position = nweParentObject.transform.position;

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
