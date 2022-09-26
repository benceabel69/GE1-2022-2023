using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate( -1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 1 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.Tab))
        {
            transform.Translate(0, -1 * Time.deltaTime, 0);
        }

    }
}
