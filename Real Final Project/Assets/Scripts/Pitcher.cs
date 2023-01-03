using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitcher : MonoBehaviour
{
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
        if (delay < Time.time)
        {
            delay = Time.time + cooldown;
            Instantiate(projectilePrefab, transform.position + new Vector3(2, 0, 2), projectilePrefab.transform.rotation);
        }
    }
}
