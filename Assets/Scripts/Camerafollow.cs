using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{

    public Transform Target;
    public float speed = 0.1f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 Desiredposition = Target.position + offset;
        Vector3 Smoothposition = Vector3.Lerp(transform.position, Desiredposition, speed); 
        transform.position = Target.position + offset;

        transform.LookAt(Target);
    }
}
