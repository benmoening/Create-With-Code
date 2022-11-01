using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackEnemy : MonoBehaviour
{
    public float speed = 1f;
    public GameObject projectilePrefab;
    public float delay = 0.0f;
    public float cooldown = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (delay < Time.time)
        {
            delay = Time.time + cooldown;
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }
    }
}
