using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody _rb;
    public float topBound = 15;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BulletMovement();
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }

    void BulletMovement()
    {
        Vector3 bulletVelocity = Vector3.forward * speed;
        transform.Translate(bulletVelocity * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Debug.Log("Destroyed Enemy");
           
        }
        
    }
}
