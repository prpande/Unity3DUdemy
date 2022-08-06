using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float waitTime = 5.0f;
    [SerializeField] float proximity = 5.0f;

    Rigidbody rigidbody;
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody.useGravity = false;
        meshRenderer.enabled = false;
        meshRenderer.material.color = Color.cyan;
    }

    // Update is called once per frame
    void Update()
    {
        var elapsedTime = Time.time;
        if(elapsedTime > waitTime)
        {
            rigidbody.useGravity = true;
            meshRenderer.enabled = true;
        }
        
    }

    private float GetDistance(Transform a, Transform b)
    {
        var distance = a.position - b.position;
        return distance.magnitude;
    }

}
