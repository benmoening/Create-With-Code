using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    public int[] lottoNumbers = { 1, 2, 3, 4, 5, 6 };
    public int myNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        myNumber = lottoNumbers[Random.Range(0, 6)];
        Debug.Log("My number is: " + myNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
