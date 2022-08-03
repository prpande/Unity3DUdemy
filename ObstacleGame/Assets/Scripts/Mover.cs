using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xMoveSpeed = 5.0f;
    [SerializeField] float yMoveSpeed = 0.0f;
    [SerializeField] float zMoveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        float yValue = 0;
        transform.Translate( xValue * xMoveSpeed, yValue * yMoveSpeed, zValue * zMoveSpeed);
    }
}
