using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogSpawnRate = 10.0f;
    public float nextDog;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            nextDog = Time.time + dogSpawnRate;
        }
    }

    // On spacebar press, send dog

}
