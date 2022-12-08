using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private float strength = 500.0f;
    public bool shouldMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove = true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            enemyRigidbody.AddForce(awayFromPlayer * strength, ForceMode.Impulse);
            Debug.Log("Player collided with " + collision.gameObject);
            shouldMove = false;
        }
    }
}
