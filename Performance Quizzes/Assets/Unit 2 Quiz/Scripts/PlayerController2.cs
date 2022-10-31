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
    public float projectileSpeed;
    
   
    

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

        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            StartCoroutine(FireRate());
            
        }
    }

    IEnumerator FireRate()
    {
        canShoot = false;
        InstantiateProjectile();
        yield return new WaitForSeconds(1.0f);
        canShoot = true;
    }

    void InstantiateProjectile()
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}
