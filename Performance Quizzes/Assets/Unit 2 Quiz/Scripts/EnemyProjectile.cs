using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BulletMovement();
    }

    void BulletMovement()
    {
        Vector3 bulletVelocity = Vector3.back * speed;
        transform.Translate(bulletVelocity * Time.deltaTime);
    }
}
