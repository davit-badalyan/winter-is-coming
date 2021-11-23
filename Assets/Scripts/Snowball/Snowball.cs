using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch (other.transform.tag)
        {
            case "Player":
                //
                break;
            default:
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
