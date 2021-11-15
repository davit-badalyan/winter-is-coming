using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public int angle = 45;
    public Vector3 offset = new Vector3(0, 12, -10);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = Quaternion.Euler(new Vector3(angle, 0, 0));
    }
}
