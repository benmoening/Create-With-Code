using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 22.5f;
    public Rigidbody PlayerRb;
    public float horizontalInput;
    public float verticalInput;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        PlayerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            Debug.Log("Hit Coin");
        }
        //fix
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(this.gameObject);
            Debug.Log("Hit Enemy");
        }
    }
}