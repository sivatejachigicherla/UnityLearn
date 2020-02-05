using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotations : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(cube, Vector3.zero, Quaternion.identity);
            Instantiate(cube, Vector3.zero, Quaternion.EulerAngles(10,0,0));

        }
    }
}
