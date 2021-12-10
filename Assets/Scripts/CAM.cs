using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAM : MonoBehaviour
{
    public Transform obj; //position of the object
    private Vector3 distance;
    private float rate = 0.5f;

    void Start()
    {
        distance = transform.position - obj.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = obj.position + distance;
        transform.position = Vector3.Slerp(transform.position, newPosition, rate);
    }
}
