using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void OnCollisionEnter(Collision other) 
    {
        score++;
        Debug.Log($"Score: {score}");
    }
}
