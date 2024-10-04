using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationReticle : MonoBehaviour
{
    public float rotateSpeed = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed * Vector3.up * Time.deltaTime);
    }
}
