using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = .10f;
    private float strength = 10.0f;
    public bool shouldMove;
    public int[] speedNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
    public float XValue;
    public float ZValue;
    private Rigidbody enemyRb;
    private GameObject player;
    private Rigidbody playerRb;
    public int throwForce;
    public bool myGravity = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
        //m_Rigidbody = GetComponent<Rigidbody>();
        //XValue = gameObject.transform.position.x;
        //ZValue = gameObject.transform.position.z;
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Bat");
        Debug.Log("Player: " + player);
        playerRb = GetComponent<Rigidbody>();
        myGravity = gameObject.GetComponent<Rigidbody>().useGravity;
        throwForce = speedNumbers[Random.Range(0, 25)];
        Debug.Log("Ball speed is: " + throwForce);
    }

    // Update is called once per frame
    void Update()
    {

        
        //enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
        //Vector3 m_Input = new Vector3(-1, 1, -1);

        if (shouldMove)
        {
            playerRb.AddForce(Vector3.forward * throwForce * Time.deltaTime, ForceMode.Impulse);
            playerRb.AddForce(Vector3.right * throwForce * Time.deltaTime, ForceMode.Impulse);
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
            //transform.Translate(Vector3.right * Time.deltaTime * speed);
            //XValue += speed;
            //ZValue += speed;
            //gameObject.transform.position = new Vector3(XValue, gameObject.transform.position.y, ZValue);
        }

        //if (shouldMove = false)
        {
            //transform.Translate(Vector3.up * Time.deltaTime * strength);
        }
        
        //m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * speed);
    }
    // transform.Translate(Vector3.forward...
    //Rigidbody.MovePosition(

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            //Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            //enemyRigidbody.AddForce(awayFromPlayer * strength, ForceMode.Impulse);
            shouldMove = false;
            //Debug.Log("Player collided with " + collision.gameObject);
            GetComponent<Rigidbody>().useGravity = true;
            myGravity = true;
        }
    }
}
