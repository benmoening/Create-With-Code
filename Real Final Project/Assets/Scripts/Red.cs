using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public int score = 3;
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
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            Debug.Log("Score: " + score);
            gameManager.UpdateScore(3);
            gameManager.ResetStrikes();
            gameManager.BallSpawn();
        }
    }
}