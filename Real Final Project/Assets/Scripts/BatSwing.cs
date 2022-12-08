using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSwing : MonoBehaviour
{
    public float strength = 15.0f;
    public float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.down * speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
    }
}
