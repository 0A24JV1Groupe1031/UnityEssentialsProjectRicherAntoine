using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed= 120.0f;
    public GameObject onCollectEffect;
    public float jumpForce = 5.0f;
    public float speed = 5.0f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start(){
      
    }

    // Update is called once per frame
    void Update(){
        transform.Rotate(0, rotationSpeed, 0);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
        // Destroy the collectible
        Destroy(gameObject);

        // instantiate the particle effect
        Instantiate(onCollectEffect, transform.position, transform.rotation);
        }


       

    }
}
