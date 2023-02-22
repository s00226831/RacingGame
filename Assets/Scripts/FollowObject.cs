using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform ObjectToFollow;
    Vector3 targetPosition;

    void Update()
    {
        targetPosition.x = ObjectToFollow.position.x;
        targetPosition.y = ObjectToFollow.position.y;
        targetPosition.z = transform.position.z;

        transform.position = targetPosition;
    }
}
