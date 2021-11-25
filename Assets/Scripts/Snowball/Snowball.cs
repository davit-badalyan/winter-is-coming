using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        string tag = other.transform.tag;

        switch (tag)
        {
            case "Player":
                // ToDo
                break;
            case "Snowball":
                // ToDo
                break;
            case "Enemy":
                // Destroy enemy and snowball
                Destroy(gameObject);
                Destroy(other.gameObject);
                break;
            default:
                // Destroy snowball
                Destroy(gameObject);
                break;
        }
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
