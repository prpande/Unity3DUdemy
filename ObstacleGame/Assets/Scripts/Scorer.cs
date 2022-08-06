using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] string hitTag = "Hit";
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != hitTag)
        {
            other.gameObject.tag = hitTag;
            score++;
            Debug.Log($"Score: {score}");
        }
    }
}
