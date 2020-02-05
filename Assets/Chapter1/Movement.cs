using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    public Vector3 startPosition;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //print if key is pressed down 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
            Destroy(this.gameObject);
            
        }
        //prints if q is pressed 
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Q pressed");
        }
        //prints if key is up
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("W pressed");
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Time.timeScale = 0.1f;
        }


        transform.Translate(Vector3.right * Time.deltaTime*speed);
        //float horizantalInput = Input.GetAxis("Horizontal");

        //transform.Translate(new Vector3(horizantalInput,0,0) * Time.deltaTime * speed);
        //float verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(0, verticalInput, 0) * Time.deltaTime * speed);

    }
}
