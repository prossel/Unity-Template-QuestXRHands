using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoBomb : MonoBehaviour
{
    // rotation speed
    public float rotationSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, 0, 1) * Time.deltaTime;
        gameObject.transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
        
    }

    // detect collision and dump destroy the collided object
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected");
        Destroy(collision.gameObject);
    }

}
