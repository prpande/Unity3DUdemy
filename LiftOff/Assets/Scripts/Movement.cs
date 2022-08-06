using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private new Rigidbody rigidbody;
    [SerializeField] private float thrustMultiplier = 1500.0f;
    [SerializeField] private float rotationMultiplier = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    private void ProcessThrust()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(thrustMultiplier * Time.deltaTime * Vector3.up);
        }
    }

    private void ProcessRotation()
    {
        var rotationAmount = rotationMultiplier * Time.deltaTime * Vector3.forward;
        rigidbody.freezeRotation = true;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(rotationAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-rotationAmount);
        }
        rigidbody.freezeRotation = false;
    }
}
