using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 5f;
    public float xRange = 5.0f;
    public float fireRate = 1.0f;
    public float cycleTime = 0.0f;
    public GameObject projectilePrefab;
    public float delay = 0.0f;
    public float cooldown = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            Debug.Log("Right Border Hit");
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            Debug.Log("Left Border Hit");
        }

        if (Input.GetKeyDown(KeyCode.Space) && delay < Time.time)
        {
            delay = Time.time + cooldown;
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 1), projectilePrefab.transform.rotation);

        }

        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            
            Destroy(this.gameObject);
            Time.timeScale = 0;
            Debug.Log("Game Over");

        }
        
    }

}
