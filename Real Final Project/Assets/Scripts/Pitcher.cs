using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pitcher : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float delay = 0.0f;
    public float cooldown = 10.0f;
    private GameManager gameManager;
    

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        
        Instantiate(projectilePrefab, transform.position + new Vector3(2, 0, 2), projectilePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //if (delay < Time.time)
        {
            //delay = Time.time + cooldown;
            //Instantiate(projectilePrefab, transform.position + new Vector3(2, 0, 2), projectilePrefab.transform.rotation);
        }

        if (gameManager.isGameActive && gameManager.isBallActive && delay < Time.time)
        {
            delay = Time.time + cooldown;
            Instantiate(projectilePrefab, transform.position + new Vector3(2, 0, 2), projectilePrefab.transform.rotation);
            gameManager.BallSpawns();
        }
        
    }

    
}
