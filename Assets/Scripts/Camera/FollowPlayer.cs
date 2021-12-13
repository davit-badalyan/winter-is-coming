using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float angle = 55;
    public GameObject player;
    public Vector3 offset = new Vector3(0, 30, -20);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = Quaternion.Euler(new Vector3(angle, 0, 0));
    }
}
