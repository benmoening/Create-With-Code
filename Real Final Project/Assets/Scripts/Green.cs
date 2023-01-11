using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball" && gameManager.isGameActive)
        {
            Destroy(collision.gameObject);
            Debug.Log("Foul Ball");
            gameManager.UpdateStrikes(1);
            gameManager.BallSpawn();
        }
    }
}
