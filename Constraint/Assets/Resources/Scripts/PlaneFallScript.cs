using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFallScript : MonoBehaviour
{
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(PlaneFall());
        }
    }

    IEnumerator PlaneFall()
    {
        yield return new WaitForSeconds(3.8f);
        rb.isKinematic = false;
        rb.useGravity = true;
        rb.detectCollisions = true;
        yield return new WaitForSeconds(2.5f);
        Destroy(this);
    }
}
