using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject projectilePrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnStuff());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnStuff()
    {
        public int i > 0, i = 1; **********************
        SpawnPrefab();
        yield return new WaitForSeconds(1.0f);
    }

    public void SpawnPrefab()
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        StartCoroutine(SpawnStuff());
    }
}
