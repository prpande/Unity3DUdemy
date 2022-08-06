using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 1500.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zValue = rotationSpeed * Time.deltaTime;
        transform.Rotate(0.0f, 0.0f, zValue, Space.Self);
    }
}
