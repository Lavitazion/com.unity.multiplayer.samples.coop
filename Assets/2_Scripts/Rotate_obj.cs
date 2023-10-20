using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_obj : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 1f;
    [SerializeField] private Vector3 rotationDirection = new ();


    void Update()
    {
        transform.Rotate(rotateSpeed * rotationDirection * Time.deltaTime);
    }
}
