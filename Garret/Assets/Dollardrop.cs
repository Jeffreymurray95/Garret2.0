using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dollardrop : MonoBehaviour
{
    public Transform spawnpoint;
    public Rigidbody dollar;

 
    void Update()
    {
        
        transform.position+=new Vector3(0.0f, -0.2f, 0.0f);
        Rigidbody rb;
        int count=0;

        if (Input.GetKey(KeyCode.A) )
        rb = Instantiate(dollar, transform.position, spawnpoint.rotation) as Rigidbody;
        count++;

    }
}
