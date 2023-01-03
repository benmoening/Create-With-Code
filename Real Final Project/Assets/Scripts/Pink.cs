using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pink : MonoBehaviour
{
    public int score = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            Debug.Log("Score: " + score);
        }
    }
}
