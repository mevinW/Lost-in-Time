using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowLab : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float xBoundLeft = -1f;
    public float xBoundRight = 1f;
    
    public Transform target;
    private Vector3 newPos;

    void Start()
    {
        newPos = new Vector3(0, 0, -10f);

    }
    void Update()
    {
        if (target.position.x > xBoundLeft && target.position.x < xBoundRight)
        {
            newPos = new Vector3(target.position.x, transform.position.y, newPos.z);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        }
    }
}