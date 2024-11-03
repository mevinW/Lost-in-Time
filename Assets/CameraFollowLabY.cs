using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowLabY : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yBoundDown = -2.75f;
    public float yBoundUp = 0f;
    
    public Transform target;
    private Vector3 newPos;

    void Start()
    {
        newPos = new Vector3(0, 0, -10f);

    }
    void Update()
    {
        if (target.position.y > yBoundDown && target.position.y < yBoundUp)
        {
            newPos = new Vector3(transform.position.x, target.position.y, newPos.z);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        }
    }
}